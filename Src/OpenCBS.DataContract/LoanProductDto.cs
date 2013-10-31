﻿// Copyright © 2013 Open Octopus Ltd.
// 
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License along
// with this program; if not, write to the Free Software Foundation, Inc.,
// 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
// 
// Website: http://www.opencbs.com
// Contact: contact@opencbs.com

using OpenCBS.Common;

namespace OpenCBS.DataContract
{
    public class LoanProductDto : DataTransferObject
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public AvailableFor AvailableFor { get; set; }
        public string PaymentFrequencyPolicy { get; set; }
        public string SchedulePolicy { get; set; }
        public string YearPolicy { get; set; }
        public string DateShiftPolicy { get; set; }
        public string RoundingPolicy { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? AmountMin { get; set; }
        public decimal? AmountMax { get; set; }
        public decimal? InterestRateMin { get; set; }
        public decimal? InterestRateMax { get; set; }
        public int? MaturityMin { get; set; }
        public int? MaturityMax { get; set; }
        public int? GracePeriodMin { get; set; }
        public int? GracePeriodMax { get; set; }
        public bool ChargeInterestDuringGracePeriod { get; set; }
    }
}
