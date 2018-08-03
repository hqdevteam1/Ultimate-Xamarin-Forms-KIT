﻿using System.Collections.Generic;
using UltimateXF.Widget.Charts.Models;
using Xamarin.Forms;

namespace DemoXF
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var entries = new List<EntryChart>();
            entries.Add(new EntryChart(0,5));
            entries.Add(new EntryChart(1,7));
            entries.Add(new EntryChart(2,10));
            entries.Add(new EntryChart(3,3));
            entries.Add(new EntryChart(4, 1));
            entries.Add(new EntryChart(5, 7));
            entries.Add(new EntryChart(6, 2));
            var dataSet = new BaseDataSet<EntryChart>(entries, "Line Chart")
            {
                DataColor = Color.Red,
                DrawMode = LineDataSetMode.CUBIC_HORIZONTAL,
                DrawCircle = false,
                DrawValue = false,
            };

            var entries2 = new List<EntryChart>();
            entries2.Add(new EntryChart(0, 1));
            entries2.Add(new EntryChart(1, 4));
            entries2.Add(new EntryChart(2, 9));
            entries2.Add(new EntryChart(3, 6));
            entries2.Add(new EntryChart(4, 3));
            entries2.Add(new EntryChart(5, 1));
            entries2.Add(new EntryChart(6, 7));
            var dataSet2 = new BaseDataSet<EntryChart>(entries2, "Line Chart 2")
            {
                DataColor = Color.Blue,
                DrawMode = LineDataSetMode.LINEAR,
                CircleColor = Color.Blue,
                CircleHoleRadius = 5,
                CircleRadius = 5
            };

            var data = new BaseData<EntryChart>(new List<IBaseDataSet<EntryChart>>{dataSet,dataSet2} ,new List<string>());
            lineChart.ChartData = data;
            lineChart2.ChartData = data;
        }
    }
}