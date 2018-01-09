using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlockchainHashing.ViewModels
{
	public class BlockchainViewmodel
	{
        public int? BlockId { get; set; }
        public Nullable<int> PatientId { get; set; }
        public string Nonce { get; set; }
        public string Data { get; set; }
        public string Hash { get; set; }
        public string PreviousHash1 { get; set; }
    }
}