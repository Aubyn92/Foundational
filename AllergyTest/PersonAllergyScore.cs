using System;
using System.Collections.Generic;

namespace AllergyTest
{
    public class PersonAllergyScore
    {
        List<string> allergyList = new List<string>();
        
        public PersonAllergyScore(int result)
            {
                foreach (Allergens name in Enum.GetValues(typeof(Allergens)))
                {
                    if (((int)name & result) != 0)
                    {
                        allergyList.Add(name.ToString());
                    }
                }
            }
        
        public List<string> List()
            {
                return allergyList;
            }
    }
}