using System.Collections.Generic;
using System.Runtime.Serialization;
using SwaggerLookup.Helpers.CherwellConnector.Enum;

namespace SwaggerLookup.Helpers.CherwellConnector.Model
{
    [DataContract]
    public class Action
    {
        [DataMember(Name = "actionType", EmitDefaultValue = false)]
        public ActionTypeEnum? ActionType { get; set; }

        [DataMember(Name = "loginEnabledMode", EmitDefaultValue = false)]
        public LoginEnabledModeEnum? LoginEnabledMode { get; set; }

        [DataMember(Name = "loginVisibilityMode", EmitDefaultValue = false)]
        public LoginVisibilityModeEnum? LoginVisibilityMode { get; set; }

        [DataMember(Name = "actionCommand", EmitDefaultValue = false)]
        public string ActionCommand { get; set; }

        [DataMember(Name = "alwaysTextAndImage", EmitDefaultValue = false)]
        public bool? AlwaysTextAndImage { get; set; }

        [DataMember(Name = "beginGroup", EmitDefaultValue = false)]
        public bool? BeginGroup { get; set; }

        [DataMember(Name = "childActions", EmitDefaultValue = false)]
        public List<Action> ChildActions { get; set; }

        [DataMember(Name = "dependencies", EmitDefaultValue = false)]
        public List<string> Dependencies { get; set; }

        [DataMember(Name = "displayText", EmitDefaultValue = false)]
        public string DisplayText { get; set; }

        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public bool? Enabled { get; set; }

        [DataMember(Name = "galleryImage", EmitDefaultValue = false)]
        public string GalleryImage { get; set; }

        [DataMember(Name = "helpText", EmitDefaultValue = false)]
        public string HelpText { get; set; }

        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        public Dictionary<string, string> Parameters { get; set; }

        [DataMember(Name = "visible", EmitDefaultValue = false)]
        public bool? Visible { get; set; }
    }
}