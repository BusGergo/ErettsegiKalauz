using CsvHelper.Configuration;
using SapiProjekt.Models;

public class BacEntryMap : ClassMap<BacEntry>
{
    public BacEntryMap()
    {
        Map(m => m.Code).Name("code");
        Map(m => m.School).Name("school");
        Map(m => m.County).Name("county");
        Map(m => m.PreviousProm).Name("previous_prom");
        Map(m => m.EducationForm).Name("education_form");
        Map(m => m.Specialization).Name("specialization");
        Map(m => m.RomanianLevel).Name("romanian_level");
        Map(m => m.NativeLevel).Name("native_level");
        Map(m => m.NativeSubject).Name("native_subject");
        Map(m => m.ExtraLanguage).Name("extra_language");
        Map(m => m.ExtraLanguageGrades).Name("extra_language_grades");
        Map(m => m.Tic).Name("tic");
        Map(m => m.MandatorySubject).Name("mandatory_subject");
        Map(m => m.ChosenSubject).Name("chosen_subject");
        Map(m => m.Avg).Name("avg");
        Map(m => m.Passed).Name("passed");
        Map(m => m.Year).Name("year");
        Map(m => m.FullSchoolName).Name("full_school_name");
        Map(m => m.City).Name("city");
        Map(m => m.Medium).Name("medium");
        Map(m => m.SchoolCode).Name("school_code");
        Map(m => m.NameHu).Name("name_hu");
        Map(m => m.CityRo).Name("city_ro");
        Map(m => m.CityHu).Name("city_hu");
        Map(m => m.CountyRo).Name("county_ro");
        Map(m => m.CountyHu).Name("county_hu");
        Map(m => m.SchoolType).Name("school_type");
        Map(m => m.MandatoryGradeInitial).Name("mandatory_grade_initial");
        Map(m => m.MandatoryGradeFinal).Name("mandatory_grade_final");
        Map(m => m.MandatoryGradeContest).Name("mandatory_grade_contestation");
        Map(m => m.ChosenGradeInitial).Name("chosen_grade_initial");
        Map(m => m.ChosenGradeFinal).Name("chosen_grade_final");
        Map(m => m.ChosenGradeContest).Name("chosen_grade_contestation");
        Map(m => m.RomanianGradeInitial).Name("romanian_grade_initial");
        Map(m => m.RomanianGradeFinal).Name("romanian_grade_final");
        Map(m => m.RomanianGradeContest).Name("romanian_grade_contestation");
        Map(m => m.NativeGradeInitial).Name("native_grade_initial");
        Map(m => m.NativeGradeFinal).Name("native_grade_final");
        Map(m => m.NativeGradeContest).Name("native_grade_contestation");
        Map(m => m.Nationality).Name("nationality");
        Map(m => m.SpecializationType).Name("specialization_type");
    }
}
