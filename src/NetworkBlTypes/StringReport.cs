namespace NetworkBlTypes
{
    public class StringReport : Report
    {
        public string Report { get; set; }

        public override void SetValue(object value)
        {
            if (value is string stringValue)
            {
                Report = stringValue;
            }
        }
    }
}