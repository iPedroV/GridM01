﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GridM01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina03 : ContentPage
    {
        public Pagina03()
        {
            InitializeComponent();
        }

        private void btVoltar(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}