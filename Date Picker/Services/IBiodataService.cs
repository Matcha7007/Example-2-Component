namespace Date_Picker.Services
{
    public interface IBiodataService
    {
        event Action OnChange;
        BiodataDto Biodata { get; set; }
        void GetValueForm(BiodataDto biodata);
        void SetValueForm(BiodataDto biodata);
        void ResetForm();
    }
}
