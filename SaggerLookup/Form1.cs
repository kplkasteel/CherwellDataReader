using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SaggerLookup.CherwellConnector;
using SaggerLookup.Enum;
using SaggerLookup.Models;
using SaggerLookup.Properties;
using SaggerLookup.Swagger.Api;
using SaggerLookup.Swagger.Model;
using Formatting = Newtonsoft.Json.Formatting;

namespace SaggerLookup
{
    public partial class Form1 : Form
    {

        private object _saveFile;

        private List<Filters> _filters = new List<Filters>();

        public Form1()
        {
            InitializeComponent();

            toolTip1.SetToolTip(txtFields, "Use comma separated values");
            toolTip1.SetToolTip(txtOperator, "Available operators are:\neq - Equals specified value\ngt - Greater than specified value\nlt - Less than specified value\ncontains - Contains specified value\nstartswith - Starts with specified value");
            toolTip1.SetToolTip(txtObjectList, "Use comma separated values");


        }

        private async void Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEndPoint.Text))
            {
                MessageBox.Show(Resources.Form1_Login_Click_Missing_Endpoint, Resources.Form1_Login_Click_Login_Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(txtClientId.Text))
            {
                MessageBox.Show(Resources.Form1_Login_Click_Missing_clientId, Resources.Form1_Login_Click_Login_Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show(Resources.Form1_Login_Click_Missing_username, Resources.Form1_Login_Click_Login_Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show(Resources.Form1_Login_Click_Missing_password, Resources.Form1_Login_Click_Login_Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            CherwellServiceApi.Instance.AuthMode = AuthModes.Internal;
            CherwellServiceApi.Instance.EndPoint = txtEndPoint.Text + "/CherwellAPI";
            CherwellServiceApi.Instance.ClientId = txtClientId.Text;
            CherwellServiceApi.Instance.UserName = txtUserName.Text;
            CherwellServiceApi.Instance.Password = txtPassword.Text;
            CherwellServiceApi.Instance.ServiceApi = new ServiceApi(CherwellServiceApi.Instance.EndPoint);
            progressBar.MarqueeAnimationSpeed = 1;
            var result = false;
            try
            {
                using (var cancellationToken = new CancellationTokenSource())
                {
                    var task = Task.Run(
                        () =>
                        {
                            StaticData.ActiveToken =
                                CherwellServiceApi.Instance.GetServiceToken(true);
                        },
                        cancellationToken.Token);
                    if (await Task.WhenAny(task).ConfigureAwait(false) == task)
                    {
                        if (StaticData.ActiveToken != null)
                        {
                            var tokenInfo = new StringBuilder();
                            tokenInfo.AppendLine(StaticData.ActiveToken.TokenType + " " +
                                                 StaticData.ActiveToken.AccessToken);
                            tokenInfo.AppendLine(StaticData.ActiveToken.AsclientId);
                            tokenInfo.AppendLine(
                                StaticData.ActiveToken.Expires + " " + StaticData.ActiveToken.ExpiresIn);
                            tokenInfo.AppendLine(StaticData.ActiveToken.Issued);
                            tokenInfo.AppendLine(StaticData.ActiveToken.RefreshToken);
                            tokenInfo.AppendLine(StaticData.ActiveToken.Username);
                            result = true;
                            txtTokenResponse.Invoke((MethodInvoker) delegate
                            {
                                txtTokenResponse.Text = tokenInfo.ToString();
                            });
                        }
                    }
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            finally
            {
                if (result)
                {
                    Settings.Default.ClientID = txtClientId.Text;
                    Settings.Default.Endpoint = txtEndPoint.Text;
                    Settings.Default.Password = txtPassword.Text;
                    Settings.Default.UserName = txtUserName.Text;
                    Settings.Default.Save();
                }

                progressBar.Invoke((MethodInvoker) delegate
                {
                    progressBar.MarqueeAnimationSpeed = 0;
                    progressBar.Refresh();
                });
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtClientId.Text = Settings.Default.ClientID;
            txtEndPoint.Text = Settings.Default.Endpoint;
            txtPassword.Text = Settings.Default.Password;
            txtUserName.Text = Settings.Default.UserName;
        }

        private async void btnSummaries_Click(object sender, EventArgs e)
        {
            if (StaticData.ActiveToken == null) return;
            progressBar.MarqueeAnimationSpeed = 1;
            var summaryList = new List<Summary>();
            try
            {
                using (var cancellationToken = new CancellationTokenSource())
                {
                    var task = Task.Run(
                        () =>
                        {
                            var list = txtObjectList.Text.Replace("\n", "").Replace("\r", "");
                            var objectList = list.Split(',');

                            summaryList.AddRange(objectList.Select(item => CherwellBusinessObjectApi.Instance.BusinessObjectGetBusinessObjectSummaryByNameV1(item)).Where(summary => summary != null));
                        },
                        cancellationToken.Token);
                    if (await Task.WhenAny(task).ConfigureAwait(false) != task) return;
                    _saveFile = summaryList;
                    txtResultBox.Invoke((MethodInvoker) delegate
                    {
                        txtResultBox.Text = JToken.Parse(JsonConvert.SerializeObject(summaryList))
                            .ToString(Formatting.Indented);
                    });
                }


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Resources.Form1_BtnTemplates_Click_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar.Invoke((MethodInvoker) delegate
                {
                    progressBar.MarqueeAnimationSpeed = 0;
                    progressBar.Refresh();
                });
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (_saveFile == null) return;
            var saveFileDialog1 = new SaveFileDialog {Filter = Resources.Form1_Save_Click_JSON_File_____json, Title = Resources.Form1_Save_Click_Save_an_json_File};
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName == "") return;
            using (var file =
                File.CreateText(saveFileDialog1.FileName))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(file, _saveFile);
            }
            _saveFile = null;
        }

        private async void BtnSchemas_Click(object sender, EventArgs e)
        {
            if (StaticData.ActiveToken == null) return;
            progressBar.MarqueeAnimationSpeed = 1;
            var schemaResponses = new List<SchemaResponse>();
            try
            {
                using (var cancellationToken = new CancellationTokenSource())
                {
                    var task = Task.Run(
                        () =>
                        {
                            var list = txtObjectList.Text.Replace("\n", "").Replace("\r", "");
                            var objectList = list.Split(',');

                            foreach (var item in objectList)
                            {
                                var summary = CherwellBusinessObjectApi.Instance
                                    .BusinessObjectGetBusinessObjectSummaryByNameV1(item);
                                if (summary == null) continue;
                                var schema =
                                    CherwellBusinessObjectApi.Instance.BusinessObjectGetBusinessObjectSchemaV1(
                                        summary.BusObId);
                                schemaResponses.Add(schema);
                                if (summary.Group == null || (bool) summary.Group) continue;
                                foreach (var groupSummary in summary.GroupSummaries)
                                {
                                    schema =
                                        CherwellBusinessObjectApi.Instance.BusinessObjectGetBusinessObjectSchemaV1(
                                            groupSummary.BusObId);
                                    schemaResponses.Add(schema);
                                }
                            }
                        },
                        cancellationToken.Token);
                    if (await Task.WhenAny(task).ConfigureAwait(false) == task)
                    {
                        _saveFile = schemaResponses;
                        txtResultBox.Invoke((MethodInvoker) delegate
                        {
                            txtResultBox.Text = JToken.Parse(JsonConvert.SerializeObject(schemaResponses))
                                .ToString(Formatting.Indented);
                        });
                    }
                }


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Resources.Form1_BtnTemplates_Click_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar.Invoke((MethodInvoker) delegate
                {
                    progressBar.MarqueeAnimationSpeed = 0;
                    progressBar.Refresh();
                });
            }
        }

        private async void BtnTemplates_Click(object sender, EventArgs e)
        {
            if (StaticData.ActiveToken == null) return;
            progressBar.MarqueeAnimationSpeed = 1;
            var templateResponses = new List<TemplateResponse>();
            try
            {
                using (var cancellationToken = new CancellationTokenSource())
                {
                    var task = Task.Run(
                        () =>
                        {
                            var list = txtObjectList.Text.Replace("\n", "").Replace("\r", "");
                            var objectList = list.Split(',');

                            foreach (var item in objectList)
                            {
                                var summary = CherwellBusinessObjectApi.Instance
                                    .BusinessObjectGetBusinessObjectSummaryByNameV1(item);
                                if (summary == null) continue;
                                var templateRequest = new TemplateRequest
                                {
                                    BusObId = summary.BusObId,
                                    IncludeRequired = true,
                                    IncludeAll = true
                                };
                                var template =
                                    CherwellBusinessObjectApi.Instance.BusinessObjectGetBusinessObjectTemplateV1(
                                        templateRequest);
                                template.BusObId = summary.BusObId;
                                template.BusObName = summary.Name;
                                templateResponses.Add(template);
                                if (summary.Group == null || (bool) summary.Group) continue;
                                foreach (var groupSummary in summary.GroupSummaries)
                                {
                                    templateRequest = new TemplateRequest
                                    {
                                        BusObId = groupSummary.BusObId,
                                        IncludeRequired = true,
                                        IncludeAll = true
                                    };
                                    template =
                                        CherwellBusinessObjectApi.Instance.BusinessObjectGetBusinessObjectTemplateV1(
                                            templateRequest);
                                    template.BusObId = summary.BusObId;
                                    template.BusObName = summary.Name;
                                    templateResponses.Add(template);
                                }
                            }
                        },
                        cancellationToken.Token);
                    if (await Task.WhenAny(task).ConfigureAwait(false) == task)
                    {
                        _saveFile = templateResponses;
                        txtResultBox.Invoke((MethodInvoker) delegate
                        {
                            txtResultBox.Text = JToken.Parse(JsonConvert.SerializeObject(templateResponses))
                                .ToString(Formatting.Indented);
                        });
                    }
                }


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Resources.Form1_BtnTemplates_Click_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar.Invoke((MethodInvoker) delegate
                {
                    progressBar.MarqueeAnimationSpeed = 0;
                    progressBar.Refresh();
                });
            }
        }

        private void btnAddFilter_Click(object sender, EventArgs e)
        {
            _filters.Add(new Filters {Field = txtFieldName.Text, Operator = txtOperator.Text, Value = txtValue.Text});
            txtResultBox.Invoke((MethodInvoker) delegate
            {
                txtFilterList.Text = JToken.Parse(JsonConvert.SerializeObject(_filters))
                    .ToString(Formatting.Indented);
            });

        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            _filters = new List<Filters>();
            txtFilterList.Text = string.Empty;
        }

        private async void btnGetLookup_Click(object sender, EventArgs e)
        {
            if (StaticData.ActiveToken == null) return;
            if (string.IsNullOrEmpty(txtLookup.Text)) return;
            progressBar.MarqueeAnimationSpeed = 1;
            var readResponses = new List<ReadResponse>();

            try
            {
                using (var cancellationToken = new CancellationTokenSource())
                {
                    var task = Task.Run(
                        () =>
                        {
                            var summary =
                                CherwellBusinessObjectApi.Instance.BusinessObjectGetBusinessObjectSummaryByNameV1(
                                    txtLookup.Text);
                            var schema =
                                CherwellBusinessObjectApi.Instance.BusinessObjectGetBusinessObjectSchemaV1(
                                    summary.BusObId);
                            var list = txtFields.Text.Replace("\n", "").Replace("\r", "");
                            var fieldList = list.Split(',');

                            var filterInfoList = (from filter in _filters
                                let fieldId =
                                    schema.FieldDefinitions.SingleOrDefault(x => x.Name == filter.Field)?.FieldId
                                where !string.IsNullOrEmpty(fieldId)
                                select new FilterInfo
                                    {FieldId = fieldId, Operator = filter.Operator, Value = filter.Value}).ToList();

                            var fields = fieldList
                                .Select(field => schema.FieldDefinitions.SingleOrDefault(x => x.Name == field)?.FieldId)
                                .Where(fieldId => !string.IsNullOrEmpty(fieldId)).ToList();

                            var searchResultsRequest = new SearchResultsRequest
                            {
                                BusObId = summary.BusObId,
                                IncludeAllFields = !fields.Any(),
                                Fields = fields.Any() ? fields : null,
                                Filters = filterInfoList,
                                PageSize = 20000
                            };

                            readResponses = CherwellSearchesApi.Instance
                                .SearchesGetSearchResultsAdHocV1(searchResultsRequest).BusinessObjects;

                        },
                        cancellationToken.Token);
                    if (await Task.WhenAny(task).ConfigureAwait(false) == task)
                    {
                        _saveFile = readResponses;
                        txtResultBox.Invoke((MethodInvoker) delegate
                        {
                            txtResultBox.Text = JToken.Parse(JsonConvert.SerializeObject(readResponses))
                                .ToString(Formatting.Indented);
                        });
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Resources.Form1_BtnTemplates_Click_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar.Invoke((MethodInvoker) delegate
                {
                    progressBar.MarqueeAnimationSpeed = 0;
                    progressBar.Refresh();
                });
            }

        }

        private async void BtnGetUsers_Click(object sender, EventArgs e)
        {
            if (StaticData.ActiveToken == null) return;

            progressBar.MarqueeAnimationSpeed = 1;
            if (chkStoreIndiviual.Checked)
            {
                folderBrowserDialog1.ShowDialog();

            }

            var users = new List<UserInfo>();

            try
            {
                using (var cancellationToken = new CancellationTokenSource())
                {
                    var task = Task.Run(
                        () =>
                        {
                            var summary =
                                CherwellBusinessObjectApi.Instance.BusinessObjectGetBusinessObjectSummaryByNameV1(
                                    "UserInfo");
                            var schema =
                                CherwellBusinessObjectApi.Instance.BusinessObjectGetBusinessObjectSchemaV1(
                                    summary.BusObId);
                            var list = txtUserFields.Text.Replace("\n", "").Replace("\r", "");
                            var fieldList = list.Split(',');

                            var fieldIds = fieldList
                                .Select(field => schema.FieldDefinitions.SingleOrDefault(x => x.Name == field)?.FieldId)
                                .Where(fieldId => !string.IsNullOrEmpty(fieldId)).ToList();

                            var searchResultRequest = new SearchResultsRequest
                            {
                                BusObId = summary.BusObId,
                                Filters = new List<FilterInfo>(),
                                PageSize = 20000,
                                IncludeAllFields = false
                            };

                            var searchResponse =
                                CherwellSearchesApi.Instance.SearchesGetSearchResultsAdHocV1(searchResultRequest);

                            foreach (var readResponse in searchResponse.BusinessObjects)
                            {
                                var filterInfo = new FilterInfo
                                {
                                    FieldId = schema.FirstRecIdField, Operator = "eq", Value = readResponse.BusObRecId
                                };
                                searchResultRequest.BusObId = readResponse.BusObId;
                                searchResultRequest.Filters = new List<FilterInfo> {filterInfo};
                                searchResultRequest.IncludeAllFields = !fieldIds.Any();
                                searchResultRequest.PageSize = 20000;
                                searchResultRequest.Fields = fieldIds.Any() ? fieldIds : null;

                                var item = CherwellSearchesApi.Instance
                                    .SearchesGetSearchResultsAdHocV1(searchResultRequest).BusinessObjects
                                    .SingleOrDefault(x => x.BusObRecId == readResponse.BusObRecId);
                                if (item == null) continue;

                                byte[] avatarBytes = null;
                                if (!string.IsNullOrEmpty(item.ReadFieldInformation("Avatar")))
                                {
                                    avatarBytes =
                                        CherwellCoreApi.Instance.CoreGetGalleryImageV1(
                                            item.ReadFieldInformation("Avatar"),
                                            null, null);
                                }

                                var teams = CherwellTeamsApi.Instance.TeamsGetUsersTeamsV2(item.BusObRecId);


                                var info = new UserInfo
                                {
                                    BusObId = readResponse.BusObRecId,
                                    BusObPublicId = readResponse.BusObPublicId,
                                    BusObRecId = readResponse.BusObRecId,
                                    FirstName = readResponse.ReadFieldInformation(nameof(UserInfo.FirstName)),
                                    FullName = readResponse.ReadFieldInformation(nameof(UserInfo.FullName)),
                                    LastName = readResponse.ReadFieldInformation(nameof(UserInfo.LastName)),
                                    Phone = readResponse.ReadFieldInformation(nameof(UserInfo.Phone)),
                                    Email = readResponse.ReadFieldInformation(nameof(UserInfo.Email)),
                                    DefaultTeamID = readResponse.ReadFieldInformation(nameof(UserInfo.DefaultTeamID)),
                                    DefaultTeamName =
                                        readResponse.ReadFieldInformation(nameof(UserInfo.DefaultTeamName)),
                                    Avatar = readResponse.ReadFieldInformation(nameof(UserInfo.Avatar)),
                                    AvatarBytes = avatarBytes,
                                    Teams = teams.Teams,
                                    LastModifiedDateTime =
                                        readResponse.ReadFieldInformation(nameof(UserInfo.LastModifiedDateTime))
                                };

                                users.Add(info);
                                if (!chkStoreIndiviual.Checked) continue;
                                if (string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath)) return;
                                using (var file =
                                    File.CreateText(Path.Combine(folderBrowserDialog1.SelectedPath,
                                        info.BusObRecId + ".json")))
                                {
                                    var serializer = new JsonSerializer();
                                    serializer.Serialize(file, info);
                                }
                            }
                        },
                        cancellationToken.Token);
                    if (await Task.WhenAny(task).ConfigureAwait(false) == task)
                    {
                        _saveFile = users;
                        txtResultBox.Invoke((MethodInvoker) delegate
                        {
                            txtResultBox.Text = JToken.Parse(JsonConvert.SerializeObject(users))
                                .ToString(Formatting.Indented);
                        });
                    }

                }



            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Resources.Form1_BtnTemplates_Click_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar.Invoke((MethodInvoker) delegate
                {
                    progressBar.MarqueeAnimationSpeed = 0;
                    progressBar.Refresh();
                });
            }
        }

        private async void btnGetTeams_Click(object sender, EventArgs e)
        {
            if (StaticData.ActiveToken == null) return;

            progressBar.MarqueeAnimationSpeed = 1;

            var teams = new List<Team>();
            try
            {
                using (var cancellationToken = new CancellationTokenSource())
                {
                    var task = Task.Run(
                        () =>
                        {
                            teams = CherwellTeamsApi.Instance.TeamsGetTeamsV2Async().Teams;


                            foreach (var team in teams)
                            {
                                team.Type = TeamType.Team.ToString();
                            }

                            var workGroups = CherwellTeamsApi.Instance.TeamsGetWorkgroupsV2().Teams;

                            foreach (var workgroup in workGroups)
                            {
                                workgroup.Type = TeamType.WorkGroup.ToString();
                            }

                            teams.AddRange(workGroups);
                        },
                        cancellationToken.Token);
                    if (await Task.WhenAny(task).ConfigureAwait(false) == task)
                    {
                        _saveFile = teams;
                        txtResultBox.Invoke((MethodInvoker) delegate
                        {
                            txtResultBox.Text = JToken.Parse(JsonConvert.SerializeObject(teams))
                                .ToString(Formatting.Indented);
                        });
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Resources.Form1_BtnTemplates_Click_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar.Invoke((MethodInvoker) delegate
                {
                    progressBar.MarqueeAnimationSpeed = 0;
                    progressBar.Refresh();
                });
            }

        }


        private void btnCustomerAddFilter_Click(object sender, EventArgs e)
        {
            _filters.Add(new Filters
            {
                Field = txtCustomerFilterFieldName.Text, Operator = txCustomerFieldOperator.Text,
                Value = txtCustomerFieldValue.Text
            });
            txtResultBox.Invoke((MethodInvoker) delegate
            {
                txtCustomerFilters.Text = JToken.Parse(JsonConvert.SerializeObject(_filters))
                    .ToString(Formatting.Indented);
            });
        }

        private void btnCustomerClearFilters_Click(object sender, EventArgs e)
        {
            _filters = new List<Filters>();
            txtFilterList.Text = string.Empty;
        }

        private async void btnCustomerGetItems_Click(object sender, EventArgs e)
        {
            if (StaticData.ActiveToken == null) return;
            progressBar.MarqueeAnimationSpeed = 1;

            if (chkStoreAsIndivilual.Checked)
            {
                folderBrowserDialog1.ShowDialog();

            }

            var customers = new List<Customer>();


            try
            {
                using (var cancellationToken = new CancellationTokenSource())
                {
                    var task = Task.Run(
                        () =>
                        {
                            lblCount.Invoke((MethodInvoker) delegate { lblCount.Text = string.Empty; });
                            var summary =
                                CherwellBusinessObjectApi.Instance.BusinessObjectGetBusinessObjectSummaryByNameV1(
                                    "Customer");
                            foreach (var groupSummary in summary.GroupSummaries)
                            {
                                var schema =
                                    CherwellBusinessObjectApi.Instance.BusinessObjectGetBusinessObjectSchemaV1(
                                        groupSummary.BusObId);
                                var list = txtCustomerFields.Text.Replace("\n", "").Replace("\r", "");
                                var fieldList = list.Split(',');

                                var filterInfoList = (from filter in _filters
                                    let fieldId =
                                        schema.FieldDefinitions.SingleOrDefault(x => x.Name == filter.Field)?.FieldId
                                    where !string.IsNullOrEmpty(fieldId)
                                    select new FilterInfo
                                        {FieldId = fieldId, Operator = filter.Operator, Value = filter.Value}).ToList();

                                var fields = fieldList
                                    .Select(field =>
                                        schema.FieldDefinitions.SingleOrDefault(x => x.Name == field)?.FieldId)
                                    .Where(fieldId => !string.IsNullOrEmpty(fieldId)).ToList();

                                var searchResultsRequest = new SearchResultsRequest
                                {
                                    BusObId = summary.BusObId,
                                    IncludeAllFields = false,
                                    Fields = null,
                                    Filters = filterInfoList,
                                    PageSize = 20000
                                };

                                var readResponses = CherwellSearchesApi.Instance
                                    .SearchesGetSearchResultsAdHocV1(searchResultsRequest).BusinessObjects;
                                foreach (var response in readResponses)
                                {
                                    searchResultsRequest = new SearchResultsRequest
                                    {
                                        BusObId = response.BusObId,
                                        IncludeAllFields = false,
                                        Fields = fields,
                                        Filters = new List<FilterInfo>
                                        {
                                            new FilterInfo
                                            {
                                                FieldId = schema.RecIdFields,
                                                Operator = "eq",
                                                Value = response.BusObRecId
                                            }
                                        },
                                    };
                                    var newCustomer =
                                        CherwellSearchesApi.Instance.SearchesGetSearchResultsAdHocV1(
                                            searchResultsRequest);

                                    if (newCustomer?.BusinessObjects == null) continue;
                                    foreach (var readResponse in newCustomer.BusinessObjects)

                                    {
                                        var avatarBytes = new byte[0];
                                        var avatar = readResponse.ReadFieldInformation("Avatar");
                                        if (!string.IsNullOrEmpty(avatar))
                                        {
                                            try
                                            {
                                                avatarBytes =
                                                    CherwellCoreApi.Instance.CoreGetGalleryImageV1(avatar, null,
                                                        null);
                                            }
                                            catch (Exception)
                                            {
                                                // do nothing.
                                            }
                                        }

                                        var customer = new Customer
                                        {
                                            BusObId = readResponse.BusObRecId,
                                            BusObPublicId = readResponse.BusObPublicId,
                                            BusObRecId = readResponse.BusObRecId,
                                            AvatarBytes = avatarBytes,
                                            FirstName = readResponse.ReadFieldInformation(
                                                nameof(Customer.FirstName)),
                                            LastName = readResponse.ReadFieldInformation(nameof(Customer.LastName)),
                                            FullName = readResponse.ReadFieldInformation(nameof(Customer.FullName)),
                                            CustomerTypeName =
                                                readResponse.ReadFieldInformation(
                                                    nameof(Customer.CustomerTypeName)),
                                            Email = readResponse.ReadFieldInformation(nameof(Customer.Email)),
                                            Phone = readResponse.ReadFieldInformation(nameof(Customer.Phone)),
                                            Department =
                                                readResponse.ReadFieldInformation(nameof(Customer.Department)),
                                            Avatar = readResponse.ReadFieldInformation(nameof(Customer.Avatar)),
                                            LastModDateTime =
                                                readResponse.ReadFieldInformation(nameof(Customer.LastModDateTime)),
                                            City = readResponse.ReadFieldInformation(nameof(Customer.City)),
                                            Address1 = readResponse.ReadFieldInformation(nameof(Customer.Address1)),
                                            Address2 = readResponse.ReadFieldInformation(nameof(Customer.Address2)),
                                            Office = readResponse.ReadFieldInformation(nameof(Customer.Office)),
                                            Building = readResponse.ReadFieldInformation(nameof(Customer.Building)),
                                            Room = readResponse.ReadFieldInformation(nameof(Customer.Room)),
                                            Country = readResponse.ReadFieldInformation(nameof(Customer.Country)),
                                            Manager = readResponse.ReadFieldInformation(nameof(Customer.Manager)),
                                            SLAName = readResponse.ReadFieldInformation(nameof(Customer.SLAName)),
                                            ProvinceStateName =
                                                readResponse.ReadFieldInformation(
                                                    nameof(Customer.ProvinceStateName)),
                                            Mobile = readResponse.ReadFieldInformation(nameof(Customer.Mobile))
                                        };
                                        customers.Add(customer);
                                        lblCount.Invoke((MethodInvoker) delegate
                                        {
                                            lblCount.Text =
                                                $"Downloaded Customer {customers.Count} out of {readResponses.Count}";});
                                        if (!chkStoreAsIndivilual.Checked) continue;
                                        if (string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath)) return;
                                        using (var file =
                                            File.CreateText(Path.Combine(folderBrowserDialog1.SelectedPath,
                                                customer.BusObRecId + ".json")))
                                        {
                                            var serializer = new JsonSerializer();
                                            serializer.Serialize(file, customer);
                                        }
                                    }
                                }
                            }

                        },

                        cancellationToken.Token);

                    if (await Task.WhenAny(task).ConfigureAwait(false) == task)
                    {
                        _saveFile = customers;
                        //txtResultBox.Invoke((MethodInvoker) delegate
                        //{
                        //    txtResultBox.Text = JToken.Parse(JsonConvert.SerializeObject(customers))
                        //        .ToString(Formatting.Indented);
                        //});
                    }
                }
            }



            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Resources.Form1_BtnTemplates_Click_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar.Invoke((MethodInvoker) delegate
                {
                    progressBar.MarqueeAnimationSpeed = 0;
                    progressBar.Refresh();
                });
            }
        }

        private async void btnSearches_Click(object sender, EventArgs e)
        {
            if (StaticData.ActiveToken == null) return;
            progressBar.MarqueeAnimationSpeed = 1;
            var searchFolders = new List<SearchFolder>();
            try
            {
                using (var cancellationToken = new CancellationTokenSource())
                {
                    var task = Task.Run(
                        () =>
                        {
                            var list = txtObjectList.Text.Replace("\n", "").Replace("\r", "");
                            var objectList = list.Split(',');
                            foreach (var association in objectList)
                            {
                                var summary =
                                    CherwellBusinessObjectApi.Instance.BusinessObjectGetBusinessObjectSummaryByNameV1(
                                        association);
                                if (summary == null) continue;

                                var searchFolder =
                                    CherwellSearchesApi.Instance.SearchesGetSearchItemsByAssociationV1(
                                        summary.BusObId);
                                searchFolders.Add(searchFolder.Root);
                            }
                        },
                        cancellationToken.Token);
                    if (await Task.WhenAny(task).ConfigureAwait(false) != task) return;
                    _saveFile = searchFolders;
                    txtResultBox.Invoke((MethodInvoker)delegate
                    {
                        txtResultBox.Text = JToken.Parse(JsonConvert.SerializeObject(searchFolders))
                            .ToString(Formatting.Indented);
                    });
                }


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Resources.Form1_BtnTemplates_Click_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar.Invoke((MethodInvoker)delegate
                {
                    progressBar.MarqueeAnimationSpeed = 0;
                    progressBar.Refresh();
                });
            }

        }

        private async void btnOneSteps_Click(object sender, EventArgs e)
        {
            if (StaticData.ActiveToken == null) return;
            progressBar.MarqueeAnimationSpeed = 1;
            var oneStepFolders = new List<ManagerFolder>();
            try
            {
                using (var cancellationToken = new CancellationTokenSource())
                {
                    var task = Task.Run(
                        () =>
                        {
                            var list = txtObjectList.Text.Replace("\n", "").Replace("\r", "");
                            var objectList = list.Split(',');
                            foreach (var association in objectList)
                            {
                                var summary =
                                    CherwellBusinessObjectApi.Instance.BusinessObjectGetBusinessObjectSummaryByNameV1(
                                        association);
                                if (summary == null) continue;
                                var oneSteps =
                                    CherwellOneStepActionsApi.Instance.OneStepActionsGetOneStepActionsByAssociationV1(summary.BusObId);
                                if (oneSteps == null) continue;
                            
                                oneStepFolders.Add(oneSteps.Root);
                            }
                        },
                        cancellationToken.Token);
                    if (await Task.WhenAny(task).ConfigureAwait(false) != task) return; 
                    _saveFile = oneStepFolders;
                    txtResultBox.Invoke((MethodInvoker)delegate
                    {
                        txtResultBox.Text = JToken.Parse(JsonConvert.SerializeObject(oneStepFolders))
                            .ToString(Formatting.Indented);
                    });
                }


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Resources.Form1_BtnTemplates_Click_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar.Invoke((MethodInvoker)delegate
                {
                    progressBar.MarqueeAnimationSpeed = 0;
                    progressBar.Refresh();
                });
            }
        }
    }

    public class Filters
    {
        public string Field { get; set; }
        public string Operator { get; set; }
        public string Value { get; set; }
    }
}