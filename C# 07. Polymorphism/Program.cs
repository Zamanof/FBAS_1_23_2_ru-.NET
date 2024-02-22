Base myBase = new();
//myBase.Show();
//Console.WriteLine(myBase.Field1);
Derived derived = new();
//derived.Show();
//Console.WriteLine(derived.Field1);

// Derived is Base
Base derive = new Derived();
//derive.Show();
//Console.WriteLine(derive.Field1);
//((Derived)derive).Show();
//((Derived)derive).Print();
//Console.WriteLine(((Derived)derive).Field1);

//Foo(myBase);
//Foo(derive);
//Foo(derived);
//Foo(new Child());
// polya i staticheskiye metodi ne moqut obyavleni virtualnimi

Base[] arr =
{
    new Base(),
    new Derived(),
    new Child()
};

foreach (var item in arr)
{
    item.Show();
}

void Foo(Base @base)
{
    #region version 1
    //if (@base.GetType() == new Derived().GetType())
    //{
    //    ((Derived)@base).Show();
    //}
    //else if (@base.GetType() == new Child().GetType())
    //{
    //    ((Child)@base).Show();
    //}
    //else
    //{
    //    @base.Show();
    //}
    #endregion

    #region version 2
    //try
    //{
    //    ((Derived)@base).Show();
    //}
    //catch (Exception)
    //{
    //}
    //try
    //{
    //    ((Child)@base).Show();
    //}
    //catch (Exception)
    //{


    //}

    //try
    //{
    //    @base.Show();
    //}
    //catch (Exception)
    //{

    //}


    #endregion

    #region version 3
    //if (@base is Derived)
    //{
    //    ((Derived)@base).Show();
    //}
    //else if(@base is Child)
    //{
    //    ((Child)@base).Show();
    //}
    //else
    //{
    //    @base.Show();
    //}
    #endregion

    #region version 4
    //var value1 = @base as Derived;
    //var value2 = @base as Child;
    //var value3 = @base as Base;
    //if (value1 is not null) value1.Show();
    //else if (value2 is not null) value2.Show();
    //else if (value3 is not null) value3.Show();
    #endregion

    @base.Show();
}


// Abstarct class, Interface