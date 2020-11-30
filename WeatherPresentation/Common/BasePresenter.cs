using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace WeatherPresentation.Common
{
    public abstract class BasePresener<TView> : IPresenter
        where TView : IView
    {
        protected TView View { get; private set; }
        protected IApplicationController Controller { get; private set; }

        protected BasePresener(IApplicationController controller, TView view)
        {
            Controller = controller;
            View = view;
        }

        public void Run()
        {
            View.Show();
        }

        //protected bool ValidationObject<Tobj>(Tobj obj)
        //{
        //    var results = new List<ValidationResult>();
        //    var context = new ValidationContext(obj);
        //    if (!Validator.TryValidateObject(obj, context, results, true))
        //    {
        //        var ErrorResult = "";
        //        foreach (var error in results)
        //        {
        //            ErrorResult += error + "\n";
        //        }
        //        View.ShowMessage(ErrorResult);
        //        return false;
        //    }
        //    return true;
        //}

        //protected bool ValidationProperty<Tprop, Tobj>(Tprop prop, string _MemberName)
        //    where Tobj : class, new()
        //{
        //    var obj = new Tobj();
        //    var results = new List<ValidationResult>();
        //    var context = new ValidationContext(obj) { MemberName = _MemberName };
        //    if (!Validator.TryValidateProperty(prop, context, results))
        //    {
        //        var ErrorResult = "";
        //        foreach (var error in results)
        //        {
        //            ErrorResult += error + "\n";
        //        }
        //        View.ShowMessage(ErrorResult);
        //        return false;
        //    }
        //    return true;
        //}
    }

    public abstract class BasePresener<TView, TArg> : IPresenter<TArg>
        where TView : IView
    {
        protected TView View { get; private set; }
        protected IApplicationController Controller { get; private set; }

        protected BasePresener(IApplicationController controller, TView view)
        {
            Controller = controller;
            View = view;
        }

        public abstract void Run(TArg argument);

        //protected bool ValidationObject<Tobj>(Tobj obj)
        //{
        //    var results = new List<ValidationResult>();
        //    var context = new ValidationContext(obj);
        //    if (!Validator.TryValidateObject(obj, context, results, true))
        //    {
        //        var ErrorResult = "";
        //        foreach (var error in results)
        //        {
        //            ErrorResult += error + "\n";
        //        }
        //        View.ShowMessage(ErrorResult);
        //        return false;
        //    }
        //    return true;
        //}

        //protected bool ValidationProperty<Tprop, Tobj>(Tprop prop, string _MemberName)
        //    where Tobj : class, new()
        //{
        //    var obj = new Tobj();
        //    var results = new List<ValidationResult>();
        //    var context = new ValidationContext(obj) { MemberName = _MemberName };
        //    if (!Validator.TryValidateProperty(prop, context, results))
        //    {
        //        var ErrorResult = "";
        //        foreach (var error in results)
        //        {
        //            ErrorResult += error + "\n";
        //        }
        //        View.ShowMessage(ErrorResult);
        //        return false;
        //    }
        //    return true;
        //}
    }
}
