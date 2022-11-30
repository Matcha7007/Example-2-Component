namespace Date_Picker.Services
{
    public class BiodataService : IBiodataService
    {
        public BiodataDto Biodata { get ; set; }

        public event Action OnChange;

        public void GetValueForm(BiodataDto biodata)
        {
            OnChange?.Invoke();
        }

        public void SetValueForm(BiodataDto biodata)
        {
            Biodata.City = biodata.City;
            Biodata.BirthDate = biodata.BirthDate;
            Biodata.Name = biodata.Name;
            Biodata.PostCode = biodata.PostCode;
            OnChange?.Invoke();
        }

        public void ResetForm()
        {
            Biodata = new BiodataDto();
            OnChange?.Invoke();
        }
    }
}
