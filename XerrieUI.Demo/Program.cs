// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Globalization;
using XerrieUI.Core;
using XerrieUI.Core.Forms;
using XerrieUI.Drawing.Fonts.Config;

Application.Initialize();

// Test code
using (var pattern = new FontSearchPattern())
{
    pattern.Add("family", "sans-serif");
    pattern.Add("family-lang", CultureInfo.CurrentUICulture.TwoLetterISOLanguageName);
    
    pattern.SetDefaultsIfAbsent();
    pattern.SetMatchKind(MatchKind.MatchFont);
    using var config = FontConfig.Reference();
    var result = config.TryMatch(pattern, out var resultPattern);
    {
        using (resultPattern)
        {
            Console.WriteLine(result);
            if (result == FontMatchResult.Match)
            {
                Console.WriteLine(resultPattern?.ToString() ?? "No match");
            }
        }
    }
}

using var window = new Window();

Application.Run(window);