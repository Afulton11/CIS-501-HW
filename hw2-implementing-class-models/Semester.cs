﻿using System;
using System.Collections.Generic;

namespace Homework
{
    public class Semester
    {
        private ICollection<Section> _sections;

        public Semester(string name)
        {
            Name = name;
            _sections = new List<Section>();
        }

        public string Name { get; private set; }

        public void IncludeSection(Section newSection)
        {
            _sections.Add(newSection);
        }
    }
}
