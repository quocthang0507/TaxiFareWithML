using System;
using TaxiFareWithMLML.Model;

namespace TaxiFareWithML
{
	class Program
	{
		static void Main(string[] args)
		{
			// Add input data
			var input = new ModelInput();
			input.Vendor_id = "CMT";
			input.Rate_code = 1;
			input.Passenger_count = 3;
			input.Trip_time_in_secs = 900;
			input.Trip_distance = 7.8f;
			input.Payment_type = "CSH"; //CSH: CASH, CRD: CREDIT

			// Load model and predict output of sample data
			ModelOutput result = ConsumeModel.Predict(input);
			Console.WriteLine($"{input.Vendor_id}\t{input.Rate_code}\t{input.Passenger_count}\t{input.Trip_time_in_secs}" +
				$"{input.Trip_distance}\t{input.Payment_type}\t{result.Score}");
		}
	}
}
