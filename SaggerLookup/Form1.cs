﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using SaggerLookup.CherwellConnector;
using SaggerLookup.Enum;
using SaggerLookup.Models;
using SaggerLookup.Properties;
using SaggerLookup.Swagger.Api;
using SaggerLookup.Swagger.Model;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaggerLookup
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _cancellationToken;

        private object saveFile;

        private List<Filters> Filters = new List<Filters>();

        public Form1()
        {
            InitializeComponent();
        }

        private async void Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEndPoint.Text))
            {
                MessageBox.Show("Missing Endpoint", "Login Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(txtClientId.Text))
            {
                MessageBox.Show("Missing clientId", "Login Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Missing username", "Login Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Missing password", "Login Error",
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
                _cancellationToken = new CancellationTokenSource();
                var task = Task.Run(
                    () =>
                    {
                        StaticData.ActiveToken =
                            CherwellServiceApi.Instance.GetServiceToken(true);
                    },
                    _cancellationToken.Token);
                if (await Task.WhenAny(task).ConfigureAwait(false) == task)
                {
                    if (StaticData.ActiveToken != null)
                    {
                        var tokenInfo = new StringBuilder();
                        tokenInfo.AppendLine(StaticData.ActiveToken.TokenType + " " + StaticData.ActiveToken.AccessToken);
                        tokenInfo.AppendLine(StaticData.ActiveToken.AsclientId);
                        tokenInfo.AppendLine(StaticData.ActiveToken.Expires + " " + StaticData.ActiveToken.ExpiresIn);
                        tokenInfo.AppendLine(StaticData.ActiveToken.Issued);
                        tokenInfo.AppendLine(StaticData.ActiveToken.RefreshToken);
                        tokenInfo.AppendLine(StaticData.ActiveToken.Username);
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
            if (StaticData.ActiveToken == null) return;
            progressBar.MarqueeAnimationSpeed = 1;
            var summaryList = new List<Summary>();
            try
            {
                _cancellationToken = new CancellationTokenSource();

                var task = Task.Run(
                    () =>
                    {
                        var list = txtObjectList.Text.Replace("\n", "").Replace("\r", "");
                        var objectList = list.Split(',');

                        foreach (var item in objectList)
                        {
                            var summary = CherwellBusinessObjectApi.Instance
                                .BusinessObjectGetBusinessObjectSummaryByNameV1(item);
                            if (summary != null) summaryList.Add(summary);
                        }
                    },
                    _cancellationToken.Token);
                if (await Task.WhenAny(task).ConfigureAwait(false) == task)
                {
                    saveFile = (object)summaryList;
                    txtResultBox.Invoke((MethodInvoker)delegate
                   {
                       txtResultBox.Text = JToken.Parse(JsonConvert.SerializeObject(summaryList))
                           .ToString(Formatting.Indented);
                   });
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (saveFile == null) return;
            var saveFileDialog1 = new SaveFileDialog { Filter = "JSON File | *.json", Title = "Save an json File" };
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName == "") return;
            using (var file =
                File.CreateText(saveFileDialog1.FileName))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(file, saveFile);
            }
            saveFile = null;
        }

        private async void btnSchemas_Click(object sender, EventArgs e)
        {
            if (StaticData.ActiveToken == null) return;
            progressBar.MarqueeAnimationSpeed = 1;
            var schemaResponses = new List<SchemaResponse>();
            try
            {
                _cancellationToken = new CancellationTokenSource();

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
                            if (summary.Group == null || (bool)summary.Group) continue;
                            foreach (var groupSummary in summary.GroupSummaries)
                            {
                                schema =
                                    CherwellBusinessObjectApi.Instance.BusinessObjectGetBusinessObjectSchemaV1(
                                        groupSummary.BusObId);
                                schemaResponses.Add(schema);
                            }
                        }
                    },
                    _cancellationToken.Token);
                if (await Task.WhenAny(task).ConfigureAwait(false) == task)
                {
                    saveFile = (object)schemaResponses;
                    txtResultBox.Invoke((MethodInvoker)delegate
                    {
                        txtResultBox.Text = JToken.Parse(JsonConvert.SerializeObject(schemaResponses))
                            .ToString(Formatting.Indented);
                    });
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private async void btnTemplates_Click(object sender, EventArgs e)
        {
            if (StaticData.ActiveToken == null) return;
            progressBar.MarqueeAnimationSpeed = 1;
            var templateResponses = new List<TemplateResponse>();
            try
            {
                _cancellationToken = new CancellationTokenSource();

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

                            templateResponses.Add(template);
                            if (summary.Group == null || (bool)summary.Group) continue;
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
                                templateResponses.Add(template);
                            }
                        }
                    },
                    _cancellationToken.Token);
                if (await Task.WhenAny(task).ConfigureAwait(false) == task)
                {
                    saveFile = (object)templateResponses;
                    txtResultBox.Invoke((MethodInvoker)delegate
                    {
                        txtResultBox.Text = JToken.Parse(JsonConvert.SerializeObject(templateResponses))
                            .ToString(Formatting.Indented);
                    });
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnAddFilter_Click(object sender, EventArgs e)
        {
            Filters.Add(new Filters{Field = txtFieldName.Text, Operator = txtOperator.Text, Value = txtValue.Text});
            txtResultBox.Invoke((MethodInvoker)delegate
            {
                txtFilterList.Text = JToken.Parse(JsonConvert.SerializeObject(Filters))
                    .ToString(Formatting.Indented);
            });

        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            Filters = new List<Filters>();
            txtFilterList.Text = string.Empty;
        }

        private async void btnGetLookup_Click(object sender, EventArgs e)
        {
            if (StaticData.ActiveToken == null) return;
            if(string.IsNullOrEmpty(txtLookup.Text)) return;
            progressBar.MarqueeAnimationSpeed = 1;
            var readResponses = new List<ReadResponse>();
           
            try
            {
                _cancellationToken = new CancellationTokenSource();

                var task = Task.Run(
                    () =>
                    {
                        var summary =
                            CherwellBusinessObjectApi.Instance.BusinessObjectGetBusinessObjectSummaryByNameV1(
                                txtLookup.Text);
                        var schema =
                            CherwellBusinessObjectApi.Instance.BusinessObjectGetBusinessObjectSchemaV1(summary.BusObId);
                         var searchResultsRequest = new SearchResultsRequest();
                         searchResultsRequest.BusObId = summary.BusObId;
                         searchResultsRequest.IncludeAllFields = true;
                         searchResultsRequest.Filters = new List<FilterInfo>();
                         searchResultsRequest.PageSize = 20000;

                         readResponses = CherwellSearchesApi.Instance.SearchesGetSearchResultsAdHocV1(searchResultsRequest).BusinessObjects;

                    },
                    _cancellationToken.Token);
                if (await Task.WhenAny(task).ConfigureAwait(false) == task)
                {
                    saveFile = (object)readResponses;
                    txtResultBox.Invoke((MethodInvoker)delegate
                    {
                        txtResultBox.Text = JToken.Parse(JsonConvert.SerializeObject(readResponses))
                            .ToString(Formatting.Indented);
                    });
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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