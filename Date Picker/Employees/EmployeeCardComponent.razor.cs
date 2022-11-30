using Microsoft.AspNetCore.Components;

namespace Date_Picker.Employees
{
    public partial class EmployeeCardComponent
    {
        [Parameter] public Employees Employee { get; set; }
    }
}
