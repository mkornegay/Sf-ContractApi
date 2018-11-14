using System;
using System.Collections.Generic;
using System.Text;

namespace Sf.ContractApi.ApplicationCore.Logging
{
    public class LoggingEvents
    {
        public const int GetItem = 1001;
        public const int ListItems = 1003;
        public const int FindItem = 1005;

        public const int CouldNotGet = 4001;
        public const int NoItemsInList = 4003;
        public const int ItemNotFound = 4005;

        public const int AppException = 5001;



    }
}
