﻿using Routing.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Share.DTOs
{
    public class MovieUpdateDTO
    {
        public Movie Movie { get; set; }
        public List<Person> Actors { get; set; }
        public List<Genre> SelectedGenres { get; set; }
        public List<Genre> NotSelectedGenres { get; set; }

    }
}
