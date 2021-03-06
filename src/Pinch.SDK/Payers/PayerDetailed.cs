﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pinch.SDK.Agreements;

namespace Pinch.SDK.Payers
{
    /// <summary>
    /// The full list of properties for a Payer
    /// </summary>
    public class PayerDetailed
    {
        /// <summary>
        /// The Payer ID
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// First Name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Last Name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Email Address
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Mobile Number
        /// </summary>
        public string MobileNumber { get; set; }
        /// <summary>
        /// BSB
        /// </summary>
        public string BSB { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        public string AccountNumber { get; set; }
        /// <summary>
        /// Account Name
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// A list of Agreements for the current payer
        /// </summary>
        public IEnumerable<Agreement> Agreements { get; set; }
    }
}
