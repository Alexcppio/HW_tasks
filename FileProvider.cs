using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW_figure_square
{
    class FileProvider : ISpecProvider<double>
    {
        private readonly string keyword;
        private readonly string filepath;
        private readonly char separator;
        public FileProvider(string path, string word, char sep)
        {
            keyword = word;
            filepath = path;
            separator = sep;
        }
        public string GetString()
        {
            using (var stringReader = File.OpenText(filepath))
            {
                if (stringReader != null)
                    return stringReader.ReadToEnd();
                throw new NullReferenceException(nameof(stringReader));
            }
        }
        public double ProvideSpecs()
        {
            var value = GetKeywordValue().Replace(".", ",");
            if (Double.TryParse(value, out double number))
                return number;
            throw new InvalidCastException(nameof(number));
        }
        private string[] GetLines() => GetString().Split('\n');
        public string GetKeywordValue()
        {
            if (GetLines() != null)
                foreach (var line in GetLines())
                    if (line.ToString().Contains(keyword) && line.ToString().Contains(separator))
                        return line.Split(separator)[1].Trim();
            throw new NullReferenceException("GetLines()");
        }
    }
}