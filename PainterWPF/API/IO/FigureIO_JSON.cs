﻿using PainterWPF.API.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Windows;

namespace PainterWPF.API.IO
{
    public class FigureIO_JSON : FigureIO
    {
        public FigureIO_JSON()
        {
            PathToFile = "";
        }
        public FigureIO_JSON(string path)
        {
            PathToFile = path;
        }


        public override List<UIElement> Read()
        {
            StreamReader fs = new StreamReader(PathToFile);
            string jsonString = fs.ReadToEnd();
            fs.Dispose();

            List<Figure> figures = JsonConvert.DeserializeObject<List<Figure>>(jsonString);

            return CreateControlList(figures);
        }

        public override void Write(List<UIElement> controls)
        {
            StreamWriter fs = new StreamWriter(PathToFile);
            fs.Write(JsonConvert.SerializeObject(GetListOfFigures(controls)));
            fs.Dispose();
        }

    }
}
