namespace magic_year
{
    class PersonalData
    {
        // data members:
        private string _firstName;
        private string _surname;
        private decimal _annualSalary;
        private int _magicYear;

        // constructor
        public PersonalData(string firstName, string surname, decimal annualSalary, int magicYear)
        {
            this._firstName = firstName;
            this._surname = surname;
            this._annualSalary = annualSalary;
            this._magicYear = magicYear;
        }

        // getter:
        public string FirstName => _firstName;
        public string Surname => _surname;
        public decimal AnnualSalary => _annualSalary;
        public int MagicYear => _magicYear;
    }
}