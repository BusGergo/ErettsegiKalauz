using System.Globalization;
using CsvHelper;
using SapiProjekt.Models;

namespace SapiProjekt.Services;

public class BacLoaderService
{
    private List<BacEntry> _entries = new();

    public List<BacEntry> Entries => _entries;

    public List<string> AvailableYears => Directory.GetFiles("Data", "*.csv")
        .Select(f => Path.GetFileNameWithoutExtension(f))
        .OrderByDescending(y => y)
        .ToList();

    public void LoadAllYears()
    {
        var allEntries = new List<BacEntry>();

        foreach (var filePath in Directory.GetFiles("Data", "*.csv"))
        {
            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            csv.Context.RegisterClassMap<BacEntryMap>();

            var records = csv.GetRecords<BacEntry>();
            allEntries.AddRange(records);
        }

        _entries = allEntries;
    }

    public List<BacEntry> GetPage(int page, int pageSize)
    {
        return _entries
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();
    }

    public int GetTotalPages(int pageSize) =>
        (int)Math.Ceiling((double)_entries.Count / pageSize);
}

