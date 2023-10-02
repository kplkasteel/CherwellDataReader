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
using SwaggerLookup.Helpers.CherwellConnector.Api;
using SwaggerLookup.Helpers.CherwellConnector.Enum;
using SwaggerLookup.Helpers.CherwellConnector.Model;
using SwaggerLookup.Models;
using SwaggerLookup.Properties;
using Formatting = Newtonsoft.Json.Formatting;

namespace SwaggerLookup
{
    public partial class Form1 : Form
    {

        private object _saveFile;

        private List<Filters> _filters = new();

        public Form1()
        {
            InitializeComponent();

            toolTip1.SetToolTip(txtFields, "Use comma separated values");
            toolTip1.SetToolTip(txtOperator, "Available operators are:\neq - Equals specified value\ngt - Greater than specified value\nlt - Less than specified value\ncontains - Contains specified value\nstartswith - Starts with specified value");
            toolTip1.SetToolTip(txtObjectList, "Use comma separated values");
            Settings.Default.Reload();
            txtEndPoint.Text = Settings.Default.Endpoint;
            txtClientId.Text = Settings.Default.ClientID;
            txtUserName.Text = Settings.Default.UserName;
            txtPassword.Text = Settings.Default.Password;
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

            ServiceApi.Instance = new ServiceApi($"{txtEndPoint.Text}/CherwellAPI", GrantTypes.password, txtClientId.Text, txtUserName.Text, txtPassword.Text, AuthModes.Internal);
            progressBar.MarqueeAnimationSpeed = 1;
            var result = false;
            try
            {
                using var cancellationToken = new CancellationTokenSource();
                var task = Task.Run(
                    () =>
                    {
                        ServiceApi.Instance.CheckTokenResponse();
                    },
                    cancellationToken.Token);
                if (await Task.WhenAny(task).ConfigureAwait(false) == task)
                {
                    if (ServiceApi.Instance.TokenResponse != null)
                    {
                        var tokenInfo = new StringBuilder();
                        tokenInfo.AppendLine(ServiceApi.Instance.TokenResponse.TokenType + " " +
                                             ServiceApi.Instance.TokenResponse.AccessToken);
                        tokenInfo.AppendLine(ServiceApi.Instance.TokenResponse.AsclientId);
                        tokenInfo.AppendLine(
                            ServiceApi.Instance.TokenResponse.Expires + " " + ServiceApi.Instance.TokenResponse.ExpiresIn);
                        tokenInfo.AppendLine(ServiceApi.Instance.TokenResponse.Issued);
                        tokenInfo.AppendLine(ServiceApi.Instance.TokenResponse.RefreshToken);
                        tokenInfo.AppendLine(ServiceApi.Instance.TokenResponse.Username);
                        result = true;
                        txtTokenResponse.Invoke((MethodInvoker)delegate
                        {
                            txtTokenResponse.Text = tokenInfo.ToString();
                        });
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

                progressBar.Invoke((MethodInvoker)delegate
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
            if (ServiceApi.Instance.TokenResponse == null) return;
            progressBar.MarqueeAnimationSpeed = 1;
            var summaryList = new List<List<Summary>>();
            try
            {
                using var cancellationToken = new CancellationTokenSource();
                var task = Task.Run(
                    () =>
                    {
                        var list = txtObjectList.Text.Replace("\n", "").Replace("\r", "");
                        var objectList = list.Split(',');
                        if(!objectList.Any()) return;
                     
                        summaryList.AddRange(objectList.Select(item => BusinessObjectApi.Instance.BusinessObjectGetBusinessObjectSummaryByNameV1(item)).Where(summary => summary != null));


                    },
                    cancellationToken.Token);
                if (await Task.WhenAny(task).ConfigureAwait(false) != task) return;
                _saveFile = summaryList;
                txtResultBox.Invoke((MethodInvoker)delegate
                {
                    txtResultBox.Text = JToken.Parse(JsonConvert.SerializeObject(summaryList))
                        .ToString(Formatting.Indented);
                });
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

        private void Save_Click(object sender, EventArgs e)
        {
            if (_saveFile == null) return;
            var saveFileDialog1 = new SaveFileDialog { Filter = Resources.Form1_Save_Click_JSON_File_____json, Title = Resources.Form1_Save_Click_Save_an_json_File };
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
            if (ServiceApi.Instance.TokenResponse == null) return;
            progressBar.MarqueeAnimationSpeed = 1;
            var schemaResponses = new List<SchemaResponse>();
            try
            {
                using var cancellationToken = new CancellationTokenSource();
                var task = Task.Run(
                    () =>
                    {
                        var list = txtObjectList.Text.Replace("\n", "").Replace("\r", "");
                        var objectList = list.Split(',');

                        foreach (var item in objectList)
                        {
                            var summary = BusinessObjectApi.Instance
                                .BusinessObjectGetBusinessObjectSummaryByNameV1(item);
                            if (summary == null) continue;
                            var schema =
                                BusinessObjectApi.Instance.BusinessObjectGetBusinessObjectSchemaV1(
                                    summary[0].BusObId);
                            schemaResponses.Add(schema);
                            if (summary[0].Group == null || !(bool)summary[0].Group) continue;
                            foreach (var groupSummary in summary[0].GroupSummaries)
                            {
                                schema =
                                   BusinessObjectApi.Instance.BusinessObjectGetBusinessObjectSchemaV1(
                                        groupSummary.BusObId);
                                schemaResponses.Add(schema);
                            }
                        }
                    },
                    cancellationToken.Token);
                if (await Task.WhenAny(task).ConfigureAwait(false) == task)
                {
                    _saveFile = schemaResponses;
                    txtResultBox.Invoke((MethodInvoker)delegate
                    {
                        txtResultBox.Text = JToken.Parse(JsonConvert.SerializeObject(schemaResponses))
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

        private async void BtnTemplates_Click(object sender, EventArgs e)
        {
            if (ServiceApi.Instance.TokenResponse == null) return;
            progressBar.MarqueeAnimationSpeed = 1;
            var templateResponses = new List<TemplateResponse>();
            try
            {
                using var cancellationToken = new CancellationTokenSource();
                var task = Task.Run(
                    () =>
                    {
                        var list = txtObjectList.Text.Replace("\n", "").Replace("\r", "");
                        var objectList = list.Split(',');

                        foreach (var item in objectList)
                        {
                            var summary = BusinessObjectApi.Instance
                                .BusinessObjectGetBusinessObjectSummaryByNameV1(item);
                            if (summary == null) continue;
                            var templateRequest = new TemplateRequest
                            {
                                BusObId = summary[0].BusObId,
                                IncludeRequired = true,
                                IncludeAll = true
                            };
                            var template =
                                BusinessObjectApi.Instance.BusinessObjectGetBusinessObjectTemplateV1(
                                    templateRequest);
                            template.BusObId = summary[0].BusObId;
                            template.BusObName = summary[0].Name;
                            templateResponses.Add(template);
                            if (summary[0].Group == null || !(bool)summary[0].Group) continue;
                            foreach (var groupSummary in summary[0].GroupSummaries)
                            {
                                templateRequest = new TemplateRequest
                                {
                                    BusObId = groupSummary.BusObId,
                                    IncludeRequired = true,
                                    IncludeAll = true
                                };
                                template =
                                    BusinessObjectApi.Instance.BusinessObjectGetBusinessObjectTemplateV1(
                                        templateRequest);
                                template.BusObId = groupSummary.BusObId;
                                template.BusObName = groupSummary.Name;
                                templateResponses.Add(template);
                            }
                        }
                    },
                    cancellationToken.Token);
                if (await Task.WhenAny(task).ConfigureAwait(false) == task)
                {
                    _saveFile = templateResponses;
                    txtResultBox.Invoke((MethodInvoker)delegate
                    {
                        txtResultBox.Text = JToken.Parse(JsonConvert.SerializeObject(templateResponses))
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

        private void BtnAddFilter_Click(object sender, EventArgs e)
        {
            _filters.Add(new Filters { Field = txtFieldName.Text, Operator = txtOperator.Text, Value = txtValue.Text });
            txtResultBox.Invoke((MethodInvoker)delegate
            {
                txtFilterList.Text = JToken.Parse(JsonConvert.SerializeObject(_filters))
                    .ToString(Formatting.Indented);
            });

        }

        private void BtnClearFilter_Click(object sender, EventArgs e)
        {
            _filters = new List<Filters>();
            txtFilterList.Text = string.Empty;
        }

        private async void btnGetLookup_Click(object sender, EventArgs e)
        {
            if (ServiceApi.Instance.TokenResponse == null) return;
            if (string.IsNullOrEmpty(txtLookup.Text)) return;
            progressBar.MarqueeAnimationSpeed = 1;
            var readResponses = new List<ReadResponse>();

            try
            {
                using var cancellationToken = new CancellationTokenSource();
                var task = Task.Run(
                    () =>
                    {
                        var summary =
                            BusinessObjectApi.Instance.BusinessObjectGetBusinessObjectSummaryByNameV1(
                                txtLookup.Text);
                        var schema =
                            BusinessObjectApi.Instance.BusinessObjectGetBusinessObjectSchemaV1(
                                summary[0].BusObId);
                        var list = txtFields.Text.Replace("\n", "").Replace("\r", "");
                        var fieldList = list.Split(',');

                        var filterInfoList = (from filter in _filters
                                              let fieldId =
                                                  schema.FieldDefinitions.SingleOrDefault(x => x.Name == filter.Field)?.FieldId
                                              where !string.IsNullOrEmpty(fieldId)
                                              select new FilterInfo
                                              { FieldId = fieldId, Operator = filter.Operator, Value = filter.Value }).ToList();

                        var fields = fieldList
                            .Select(field => schema.FieldDefinitions.SingleOrDefault(x => x.Name == field)?.FieldId)
                            .Where(fieldId => !string.IsNullOrEmpty(fieldId)).ToList();

                        var searchResultsRequest = new SearchResultsRequest
                        {
                            BusObId = summary[0].BusObId,
                            IncludeAllFields = !fields.Any(),
                            Fields = fields.Any() ? fields : null,
                            Filters = filterInfoList,
                            PageSize = 20000
                        };

                        readResponses = SearchesApi.Instance
                            .SearchesGetSearchResultsAdHocV1(searchResultsRequest).BusinessObjects;

                    },
                    cancellationToken.Token);
                if (await Task.WhenAny(task).ConfigureAwait(false) == task)
                {
                    _saveFile = readResponses;
                    txtResultBox.Invoke((MethodInvoker)delegate
                    {
                        txtResultBox.Text = JToken.Parse(JsonConvert.SerializeObject(readResponses))
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

        private async void BtnGetUsers_Click(object sender, EventArgs e)
        {
            if (ServiceApi.Instance.TokenResponse == null) return;

            progressBar.MarqueeAnimationSpeed = 1;
            if (chkStoreIndiviual.Checked)
            {
                folderBrowserDialog1.ShowDialog();

            }

            var users = new List<UserInfo>();

            try
            {
                using var cancellationToken = new CancellationTokenSource();
                var task = Task.Run(
                    () =>
                    {
                        var summary =
                            BusinessObjectApi.Instance.BusinessObjectGetBusinessObjectSummaryByNameV1(
                                "UserInfo");
                        var schema =
                            BusinessObjectApi.Instance.BusinessObjectGetBusinessObjectSchemaV1(
                                summary[0].BusObId);
                        var list = txtUserFields.Text.Replace("\n", "").Replace("\r", "");
                        var fieldList = list.Split(',');

                        var fieldIds = fieldList
                            .Select(field => schema.FieldDefinitions.SingleOrDefault(x => x.Name == field)?.FieldId)
                            .Where(fieldId => !string.IsNullOrEmpty(fieldId)).ToList();

                        var searchResultRequest = new SearchResultsRequest
                        {
                            BusObId = summary[0].BusObId,
                            Filters = new List<FilterInfo>(),
                            PageSize = 20000,
                            IncludeAllFields = false
                        };

                        var searchResponse =
                            SearchesApi.Instance.SearchesGetSearchResultsAdHocV1(searchResultRequest);
                        var count = 0;
                        foreach (var readResponse in searchResponse.BusinessObjects)
                        {
                            var filterInfo = new FilterInfo
                            {
                                FieldId = schema.FirstRecIdField,
                                Operator = "eq",
                                Value = readResponse.BusObRecId
                            };
                            searchResultRequest.BusObId = readResponse.BusObId;
                            searchResultRequest.Filters = new List<FilterInfo> { filterInfo };
                            searchResultRequest.IncludeAllFields = !fieldIds.Any();
                            searchResultRequest.PageSize = 20000;
                            searchResultRequest.Fields = fieldIds.Any() ? fieldIds : null;

                            lblUserTotal.Invoke((MethodInvoker)delegate
                            {
                                lblUserTotal.Text = $@"Downloading {++count} of {searchResponse.BusinessObjects.Count} users";
                            });

                            var item = SearchesApi.Instance
                                .SearchesGetSearchResultsAdHocV1(searchResultRequest).BusinessObjects
                                .SingleOrDefault(x => x.BusObRecId == readResponse.BusObRecId);
                            if (item == null) continue;

                            byte[] avatarBytes = null;
                            if (!string.IsNullOrEmpty(item.ReadFieldInformation(nameof(UserInfo.Avatar))))
                            {
                                avatarBytes =
                                    CoreApi.Instance.CoreGetGalleryImageV1(
                                        item.ReadFieldInformation(nameof(UserInfo.Avatar)));
                            }

                            var teams = TeamsApi.Instance.TeamsGetUsersTeamsV2(item.BusObRecId);


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
                            using var file =
                                File.CreateText(Path.Combine(folderBrowserDialog1.SelectedPath,
                                    info.BusObRecId + ".json"));
                            var serializer = new JsonSerializer();
                            serializer.Serialize(file, info);
                        }
                    },
                    cancellationToken.Token);
                if (await Task.WhenAny(task).ConfigureAwait(false) == task)
                {
                    _saveFile = users;
                    txtResultBox.Invoke((MethodInvoker)delegate
                    {
                        txtResultBox.Text = JToken.Parse(JsonConvert.SerializeObject(users))
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

        private async void btnGetTeams_Click(object sender, EventArgs e)
        {
            if (ServiceApi.Instance.TokenResponse == null) return;

            progressBar.MarqueeAnimationSpeed = 1;

            var teams = new List<Team>();
            try
            {
                using var cancellationToken = new CancellationTokenSource();
                var task = Task.Run(
                    () =>
                    {
                        teams = TeamsApi.Instance.TeamsGetTeamsV2().Teams;


                        foreach (var team in teams)
                        {
                            team.Type = TeamType.Team.ToString();
                        }

                        var workGroups = TeamsApi.Instance.TeamsGetWorkgroupsV2().Teams;

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
                    txtResultBox.Invoke((MethodInvoker)delegate
                    {
                        txtResultBox.Text = JToken.Parse(JsonConvert.SerializeObject(teams))
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


        private void BtnCustomerAddFilter_Click(object sender, EventArgs e)
        {
            _filters.Add(new Filters
            {
                Field = txtCustomerFilterFieldName.Text,
                Operator = txCustomerFieldOperator.Text,
                Value = txtCustomerFieldValue.Text
            });
            txtResultBox.Invoke((MethodInvoker)delegate
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

        private async void BtnCustomerGetItems_Click(object sender, EventArgs e)
        {
            if (ServiceApi.Instance.TokenResponse == null) return;
            progressBar.MarqueeAnimationSpeed = 1;

            if (chkStoreAsIndivilual.Checked)
            {
                folderBrowserDialog1.ShowDialog();

            }

            var customers = new List<Customer>();


            try
            {
                using var cancellationToken = new CancellationTokenSource();
                var task = Task.Run(
                    () =>
                    {
                        lblCount.Invoke((MethodInvoker)delegate { lblCount.Text = string.Empty; });
                        var summary =
                            BusinessObjectApi.Instance.BusinessObjectGetBusinessObjectSummaryByNameV1(
                                "Customer");
                        foreach (var groupSummary in summary[0].GroupSummaries)
                        {
                            var schema =
                                BusinessObjectApi.Instance.BusinessObjectGetBusinessObjectSchemaV1(
                                    groupSummary.BusObId);
                            var list = txtCustomerFields.Text.Replace("\n", "").Replace("\r", "");
                            var fieldList = list.Split(',');

                            var filterInfoList = (from filter in _filters
                                                  let fieldId =
                                                      schema.FieldDefinitions.SingleOrDefault(x => x.Name == filter.Field)?.FieldId
                                                  where !string.IsNullOrEmpty(fieldId)
                                                  select new FilterInfo
                                                  { FieldId = fieldId, Operator = filter.Operator, Value = filter.Value }).ToList();

                            var fields = fieldList
                                .Select(field =>
                                    schema.FieldDefinitions.SingleOrDefault(x => x.Name == field)?.FieldId)
                                .Where(fieldId => !string.IsNullOrEmpty(fieldId)).ToList();

                            var searchResultsRequest = new SearchResultsRequest
                            {
                                BusObId = summary[0].BusObId,
                                IncludeAllFields = false,
                                Fields = null,
                                Filters = filterInfoList,
                                PageSize = 20000
                            };

                            var readResponses = SearchesApi.Instance
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
                                        new()
                                        {
                                            FieldId = schema.RecIdFields,
                                            Operator = "eq",
                                            Value = response.BusObRecId
                                        }
                                    },
                                };
                                var newCustomer =
                                    SearchesApi.Instance.SearchesGetSearchResultsAdHocV1(
                                        searchResultsRequest);

                                if (newCustomer?.BusinessObjects == null) continue;
                                foreach (var readResponse in newCustomer.BusinessObjects)

                                {
                                    var avatarBytes = Array.Empty<byte>();
                                    var avatar = readResponse.ReadFieldInformation(nameof(UserInfo.Avatar));
                                    if (!string.IsNullOrEmpty(avatar))
                                    {
                                        try
                                        {
                                            avatarBytes =
                                                CoreApi.Instance.CoreGetGalleryImageV1(avatar);
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
                                    lblCount.Invoke((MethodInvoker)delegate
                                    {
                                        lblCount.Text =
                                            $@"Downloaded Customer {customers.Count} out of {readResponses.Count}";
                                    });
                                    if (!chkStoreAsIndivilual.Checked) continue;
                                    if (string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath)) return;
                                    using var file =
                                        File.CreateText(Path.Combine(folderBrowserDialog1.SelectedPath,
                                            customer.BusObRecId + ".json"));
                                    var serializer = new JsonSerializer();
                                    serializer.Serialize(file, customer);
                                }
                            }
                        }

                    },

                    cancellationToken.Token);

                if (await Task.WhenAny(task).ConfigureAwait(false) == task)
                {
                    _saveFile = customers;
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

        private async void btnSearches_Click(object sender, EventArgs e)
        {
            if (ServiceApi.Instance.TokenResponse == null) return;
            progressBar.MarqueeAnimationSpeed = 1;
            var searchFolders = new List<SearchesSearchFolder>();
            try
            {
                using var cancellationToken = new CancellationTokenSource();
                var task = Task.Run(
                    () =>
                    {
                        var list = txtObjectList.Text.Replace("\n", "").Replace("\r", "");
                        var objectList = list.Split(',');
                        foreach (var association in objectList)
                        {
                            var summary =
                                BusinessObjectApi.Instance.BusinessObjectGetBusinessObjectSummaryByNameV1(
                                    association);
                            if (summary == null) continue;

                            var searchFolder =
                                SearchesApi.Instance.SearchesGetSearchItemsByAssociationV1(
                                    summary[0].BusObId);
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
            if (ServiceApi.Instance.TokenResponse == null) return;
            progressBar.MarqueeAnimationSpeed = 1;
            var oneStepFolders = new List<ManagerFolder>();
            try
            {
                using var cancellationToken = new CancellationTokenSource();
                var task = Task.Run(
                    () =>
                    {
                        var list = txtObjectList.Text.Replace("\n", "").Replace("\r", "");
                        var objectList = list.Split(',');
                        foreach (var association in objectList)
                        {
                            var summary =
                                BusinessObjectApi.Instance.BusinessObjectGetBusinessObjectSummaryByNameV1(
                                    association);
                            if (summary == null) continue;
                            var oneSteps =
                                OneStepActionsApi.Instance.OneStepActionsGetOneStepActionsByAssociationV1(summary[0].BusObId);
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

        private void txtEndPoint_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.Endpoint = txtEndPoint.Text;
            Settings.Default.Save();
        }

        private void txtClientId_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.ClientID = txtClientId.Text;
            Settings.Default.Save();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.UserName = txtUserName.Text;
            Settings.Default.Save();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.Password = txtPassword.Text;
            Settings.Default.Save();
        }
    }

    public class Filters
    {
        public string Field { get; set; }
        public string Operator { get; set; }
        public string Value { get; set; }
    }
}