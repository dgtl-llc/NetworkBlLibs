using System;

namespace NetworkBlTypes
{
    public class Report
    {
        public bool IsError { get; set; }
        public string ErrorMessage { get; set; }

        public virtual void SetValue(object value)
        {
            throw new NotImplementedException();
        }
    }
}