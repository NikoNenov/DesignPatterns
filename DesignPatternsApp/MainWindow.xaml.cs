using System;
using System.Windows;
using Nenov.DesignPatterns.Adapter.Structural;
using Nenov.DesignPatterns.Adapter.Structural.AdapterA;
using Nenov.DesignPatterns.Decorator.Structural;

namespace Nenov.DesignPatternsApp
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Execute decorator design pattern example
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Decorator_OnClick(object sender, RoutedEventArgs e)
    {
      var simpleComponent = new ConcreteComponent();
      DesignPatternsLog.Text += $"Decorator@ I get a simple component: {simpleComponent.Operation()}";
      DesignPatternsLog.Text += $"{Environment.NewLine}";

      // Note how decorators can wrap not only simple components
      // but the other decorators as well.
      var decoratorA = new ConcreteDecoratorA(simpleComponent);
      var decoratorB = new ConcreteDecoratorB(decoratorA);
      DesignPatternsLog.Text += $"Decorator@ Now I've got a decorated component: {decoratorB.Operation()}";
      DesignPatternsLog.Text += $"{Environment.NewLine}";
    }

    /// <summary>
    /// Execute adapter design pattern example
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Adapter_OnClick(object sender, RoutedEventArgs e)
    {
      var adapteeA = new AdapteeA();
      ITarget targetA = new Adapter(adapteeA);

      DesignPatternsLog.Text += $"Adapter@ Adaptee interface is incompatible with the client. {Environment.NewLine}" +
                                $"Adapter@ But with adapter Adapter client can call it's method. {Environment.NewLine}";
      DesignPatternsLog.Text += $"Adapter@ {targetA.GetRequest()}{Environment.NewLine}";
    }
  }
}
