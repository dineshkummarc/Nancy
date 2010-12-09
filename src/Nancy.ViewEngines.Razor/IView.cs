﻿
using System.IO;
namespace Nancy.ViewEngines.Razor {
    public interface IView {
        string Code { get; set; }
        object Model { get; set; }
        TextWriter Writer { get; set; }
        void Execute();
    }
}
