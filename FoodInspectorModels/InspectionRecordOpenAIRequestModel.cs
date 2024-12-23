namespace FoodInspectorModels
{
    public class InspectionRecordOpenAIRequestModel
    {
        public string? ProgramIdentifier { get; set; }
        public string? InspectionScore { get; set; }
        public string? InspectionResult { get; set; }
        public bool? InspectionClosedBusiness { get; set; }
        public List<Violation>? Violations { get; set; }
        public string? InspectionSerialNum { get; set; }
    }
}