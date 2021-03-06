﻿using PainterWPF.API.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Windows;

namespace PainterWPF.API.IO
{
    public class FigureIO_XML : FigureIO
    {
        public FigureIO_XML()
        {
            PathToFile = "";
        }
        public FigureIO_XML(string path)
        {
            PathToFile = path;
        }


        public override List<UIElement> Read()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Figure>));

            StreamReader fs = new StreamReader(PathToFile);

            XmlReader reader = XmlReader.Create(fs);
            List<Figure> figures = (List<Figure>)serializer.Deserialize(reader);
            reader.Dispose();
            fs.Dispose();

            return CreateControlList(figures);
        }

        public override void Write(List<UIElement> controls)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Figure>));
            StreamWriter fs = new StreamWriter(PathToFile);
            serializer.Serialize(fs, GetListOfFigures(controls));
            fs.Dispose();
        }

    }
}
