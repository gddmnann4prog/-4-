﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab4
{
    public static class StaticData
    {
        
        public static string pattern2 = @"(a*bc+)|(0*12*0)";
        public static string pattern3 = @"(a+b+c)|(012(12)*3*)";
        public static Regex rx;
        public static bool usingMyRegex;
        public static DefaultDialogService dialogService = new DefaultDialogService();
        public static DefaultFileService fileService = new DefaultFileService();
        public static LanguageProcessorForm mainForm;
        public static string currentData = "";
        public static bool unsaved = false;
        public static Stack<string> undoStack = new Stack<string>();
        public static Stack<string> redoStack = new Stack<string>();
        public static Commands commands = new Commands();
    }
}
