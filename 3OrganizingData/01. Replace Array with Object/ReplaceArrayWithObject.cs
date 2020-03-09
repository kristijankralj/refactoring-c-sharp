using System;

namespace OrganizingData
{
    public class UrlChecker
    {
        private string _urlParameters;

        public UrlChecker(string parameters)
        {
            //url parameters example page=a145108278w206732993p199568447&date00=20191213&date01=20191213&date10=20191111&date11=20191212/
            string[] urlParts = parameters.Split('&');
            string pageId = urlParts[0];
            string startDateFirstPeriod = urlParts[1];
            string endDateFirstPeriod = urlParts[2];
            string startDateSecondPeriod = urlParts[3];
            string endDateSecondPeriod = urlParts[4];

            if (string.IsNullOrEmpty(pageId))
            {
                throw new ArgumentException("Page id is not valid.");
            }

            if (!DateTime.TryParse(startDateFirstPeriod, out _))
            {
                throw new ArgumentException("Start date of the first period is not valid.");
            }
            if (!DateTime.TryParse(endDateFirstPeriod, out _))
            {
                throw new ArgumentException("End date of the first period is not valid.");
            }
            if (!DateTime.TryParse(startDateSecondPeriod, out _))
            {
                throw new ArgumentException("Start date of the second period is not valid.");
            }
            if (!DateTime.TryParse(endDateSecondPeriod, out _))
            {
                throw new ArgumentException("End date of second period is not valid.");
            }
            //All checks are fine, assign to _urlParameters
            _urlParameters = parameters;
        }
    }
}
