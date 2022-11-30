using Microsoft.AspNetCore.Components;

using System.Net.Http.Json;

namespace Date_Picker.Employees
{
    public partial class EmployeeListComponent : ComponentBase
    {
        [Inject] private HttpClient _http { get; set; }
        public Employees[] EmployeesList { get; set; } = new Employees[0];
        protected override async Task OnInitializedAsync()
        {
            EmployeesList = await _http.GetFromJsonAsync<Employees[]>("./sample-data/employees.json");

        }
    }
}
