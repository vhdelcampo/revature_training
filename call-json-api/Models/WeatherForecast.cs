﻿// See https://www.metaweather.com/api/location/search/?query=melbourne for location search
// See https://www.metaweather.com/api/location/1103816/ for weather data
// See https://www.metaweather.com/api/#location for API docs

using System;
using System.Collections.Generic;

namespace call_json_api.Models
{
    public class ConsolidatedWeather
    {
        public object id { get; set; }
        public string weather_state_name { get; set; }
        public string weather_state_abbr { get; set; }
        public string wind_direction_compass { get; set; }
        public DateTime created { get; set; }
        public string applicable_date { get; set; }
        public double min_temp { get; set; }
        public double max_temp { get; set; }
        public double the_temp { get; set; }
        public double wind_speed { get; set; }
        public double wind_direction { get; set; }
        public double air_pressure { get; set; }
        public int humidity { get; set; }
        public double visibility { get; set; }
        public int predictability { get; set; }
    }

    public class Parent
    {
        public string title { get; set; }
        public string location_type { get; set; }
        public int woeid { get; set; }
        public string latt_long { get; set; }
    }

    public class Source
    {
        public string title { get; set; }
        public string slug { get; set; }
        public string url { get; set; }
        public int crawl_rate { get; set; }
    }

    public class WeatherForecast
    {
        public List<ConsolidatedWeather> consolidated_weather { get; set; }
        public DateTime time { get; set; }
        public DateTime sun_rise { get; set; }
        public DateTime sun_set { get; set; }
        public string timezone_name { get; set; }
        public Parent parent { get; set; }
        public List<Source> sources { get; set; }
        public string title { get; set; }
        public string location_type { get; set; }
        public int woeid { get; set; }
        public string latt_long { get; set; }
        public string timezone { get; set; }
    }
}