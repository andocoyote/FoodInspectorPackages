﻿namespace FoodInspectorModels
{
    public class InspectionRecordAggregated
    {
        public string? ProgramIdentifier { get; set; }
        public string? Name { get; set; }
        public DateTime? InspectionDate { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? ZipCode { get; set; }
        public string? InspectionBusinessName { get; set; }
        public string? InspectionType { get; set; }
        public string? InspectionScore { get; set; }
        public string? InspectionResult { get; set; }
        public bool? InspectionClosedBusiness { get; set; }
        public List<Violation>? Violations { get; set; }
        public string? InspectionSerialNum { get; set; }
    }
}