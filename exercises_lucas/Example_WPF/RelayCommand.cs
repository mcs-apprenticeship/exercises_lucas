using System;
using System.Windows.Input;

namespace Example_WPF
{
    /// <summary>
    /// An implementation of the <see cref="ICommand"/> interface so it can easily be used in our view models for binding interactive controls (e.g. buttons).
    /// </summary>
    internal class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        readonly Action<object?> execute;
        readonly Predicate<object?>? canExecute;

        public RelayCommand(Action<object?> execute) : this(execute, null)
        {
        }

        public RelayCommand(Action<object?> execute, Predicate<object?>? canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object? parameter)
        {
            return canExecute?.Invoke(parameter) ?? true;
        }

        public void Execute(object? parameter)
        {
            execute?.Invoke(parameter);
        }
    }
}