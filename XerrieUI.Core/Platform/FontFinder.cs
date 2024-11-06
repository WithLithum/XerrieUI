// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using XerrieUI.Drawing.Fonts.Config;
namespace XerrieUI.Core.Platform;

public static class FontFinder
{
    private static readonly Dictionary<string, FoundFontInfo> FontPatternCache = [];

    public static FoundFontInfo? FindCached(string pattern)
    {
        if (FontPatternCache.TryGetValue(pattern, out var cached))
        {
            return cached;
        }
        
        using var config = FontConfig.Reference();
        using var fcPattern = FontPattern.Parse(pattern);
        fcPattern.SetDefaultsIfAbsent();
        fcPattern.SetMatchKind(MatchKind.FcMatchPattern);
        
        var matchResult = config.TryMatch(fcPattern, out var result);
        if (matchResult != FontMatchResult.Match || result == null)
        {
            return null;
        }

        using (result)
        {
            var file = result.GetStringProperty("file", 0);
            var index = result.GetInt32Property("index", 0);
            var size = result.GetDoubleProperty("size", 0);

            if (file == null)
            {
                return null;
            }
            
            var resultInfo = new FoundFontInfo(file, index, size);
            FontPatternCache.Add(pattern, resultInfo);
            return resultInfo;
        }
    }
}