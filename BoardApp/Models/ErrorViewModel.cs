// Programmer name : BoardApp Group
// Student nr      : 222049725;223022994;225007032;220024412;225004492
// Assignment nr   : Practical Assessment 1
// Purpose         : View model used by the Error view to optionally
//                  display a request identifier for diagnostic purposes

namespace BoardApp.Models
{
    public class ErrorViewModel
    {
        public string? RequestId
        {
            //
            //Name              : property string? RequestId
            //Purpose           : Automatic public property giving access
            //                  to the corresponding compiler generated
            //                  field; holds the current request's
            //                  identifier, if available
            //Re-use            : none
            //Input Parameter   : string? value
            //                  - new value for the corresponding
            //                  compiler generated field
            //Output Type       : string?
            //                  - value stored in the corresponding
            //                  compiler generated field
            //
            get; set;
        } // end property

        public bool ShowRequestId
        {
            //
            //Name              : property bool ShowRequestId
            //Purpose           : Computed read-only property indicating
            //                  whether RequestId currently holds a
            //                  non-empty value
            //Re-use            : none
            //Input Parameter   : None
            //Output Type       : bool
            //                  - true if RequestId is not null or empty,
            //                  otherwise false
            //
            get => !string.IsNullOrEmpty(RequestId);
        } // end property
    } // end class ErrorViewModel
} // end namespace BoardApp.Models