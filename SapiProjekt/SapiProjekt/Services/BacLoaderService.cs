using System.Globalization;
using CsvHelper;
using SapiProjekt.Models;

namespace SapiProjekt.Services;

public class BacLoaderService
{
    private List<BacEntry> _entries = new();
    private string _currentYear = null;

    public List<string> AvailableYears => Directory.GetFiles("Data", "*.csv")
        .Select(f => Path.GetFileNameWithoutExtension(f))
        .OrderByDescending(y => y)
        .ToList();

    public List<BacEntry> GetPage(int page, int pageSize)
    {
        return _entries
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();
    }

    public int GetTotalPages(int pageSize) => 
        (int)Math.Ceiling((double)_entries.Count / pageSize);

    public void LoadYear(string year)
    {
        if (year == _currentYear)
            return;

        string filePath = Path.Combine("Data", $"{year}.csv");
        if (!File.Exists(filePath))
            throw new FileNotFoundException($"CSV for year {year} not found.");

        using var reader = new StreamReader(filePath);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        csv.Context.RegisterClassMap<BacEntryMap>();
        _entries = csv.GetRecords<BacEntry>().ToList();
        _currentYear = year;
    }
}
