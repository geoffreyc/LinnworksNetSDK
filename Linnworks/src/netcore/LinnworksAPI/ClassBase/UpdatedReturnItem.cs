using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdatedReturnItem
	{
		public Int32 RMARowId;

		public Boolean RemoveFromBooking;

		public Guid OrderItemRowId;

		public Int32? BatchInventoryId;

		public Guid ReturnLocation;

		public Int32 ReturnQuantity;

		public Decimal RefundAmount;

		public Guid? RefundRowId;

		public Int32 ScrapQuantity;

		public String ReasonCategory;

		public Boolean IsFreeText;

		public String Reason;

		public String ReasonTag;

		public String SubReasonTag;
	} 
}