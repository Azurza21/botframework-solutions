// <auto-generated>
// Code generated by LUISGen
// Tool github: https://github.com/microsoft/botbuilder-tools
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>
using Newtonsoft.Json;
using System.Collections.Generic;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.AI.Luis;

namespace Luis
{
    public class VehicleSettingsLuis: IRecognizerConvert
    {
        public string Text;
        public string AlteredText;
        public enum Intent {
            None, 
            VEHICLE_SETTINGS_CHANGE, 
            VEHICLE_SETTINGS_CHECK, 
            VEHICLE_SETTINGS_DECLARATIVE
        };
        public virtual Dictionary<Intent, IntentScore> Intents { get; set; }

        public class _Entities
        {
            // Simple entities
            public string[] AMOUNT;
            public string[] INDEX;
            public string[] SETTING;
            public string[] TYPE;
            public string[] UNIT;
            public string[] VALUE;

            // Instance
            public class _Instance
            {
                public InstanceData[] AMOUNT;
                public InstanceData[] INDEX;
                public InstanceData[] SETTING;
                public InstanceData[] TYPE;
                public InstanceData[] UNIT;
                public InstanceData[] VALUE;
            }
            [JsonProperty("$instance")]
            public _Instance _instance;
        }
        public virtual _Entities Entities { get; set; }

        [JsonExtensionData(ReadData = true, WriteData = true)]
        public IDictionary<string, object> Properties {get; set; }

        public void Convert(dynamic result)
        {
            var app = JsonConvert.DeserializeObject<VehicleSettingsLuis>(JsonConvert.SerializeObject(result));
            Text = app.Text;
            AlteredText = app.AlteredText;
            Intents = app.Intents;
            Entities = app.Entities;
            Properties = app.Properties;
        }

        public virtual (Intent intent, double score) TopIntent()
        {
            Intent maxIntent = Intent.None;
            var max = 0.0;
            foreach (var entry in Intents)
            {
                if (entry.Value.Score > max)
                {
                    maxIntent = entry.Key;
                    max = entry.Value.Score.Value;
                }
            }
            return (maxIntent, max);
        }
    }
}