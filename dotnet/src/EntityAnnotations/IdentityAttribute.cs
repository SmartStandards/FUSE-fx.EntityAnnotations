namespace System.ComponentModel.DataAnnotations {
	public class IdentityAttribute : Attribute {

		public string ColumnName { get; set; }
		public int Seed { get; set; } = 1;
		public int Increment { get; set; } = 1;

		public IdentityAttribute(
			string columnName, int seed = 1, int increment = 1
		) {
			ColumnName = columnName;
			Seed = seed;
			Increment = increment;
		}
	}
}
