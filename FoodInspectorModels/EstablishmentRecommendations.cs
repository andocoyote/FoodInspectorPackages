using System.Text.Json.Serialization;

namespace FoodInspectorModels
{
    public class EstablishmentRecommendations
    {
        [JsonPropertyName("recommended")]
        public List<InspectionRecordAggregated>? Recommended { get; set; }

        [JsonPropertyName("unrecommended")]
        public List<InspectionRecordAggregated>? Unrecommended { get; set; }
    }

}