﻿using System;
using System.Collections.Specialized;
using System.ComponentModel;
using Neutronium.Core.Binding.GlueObject.Executable;

namespace Neutronium.Core.Binding.Listeners
{
    public class ObjectChangesListener : IObjectChangesListener
    {
        private readonly Action<INotifyPropertyChanged> _OnObject;
        private readonly Action<INotifyCollectionChanged> _OnCollection;
        private readonly Action<JsCommandBase> _OnCommand;

        public ObjectChangesListener(Action<INotifyPropertyChanged> onObject,
                            Action<INotifyCollectionChanged> onCollection, Action<JsCommandBase> onCommand)
        {
            _OnObject = onObject;
            _OnCollection = onCollection;
            _OnCommand = onCommand;
        }

        public void OnObject(INotifyPropertyChanged listenedObject)
        {
            _OnObject(listenedObject);
        }

        public void OnCollection(INotifyCollectionChanged collection)
        {
            _OnCollection(collection);
        }

        public void OnCommand(JsCommandBase command)
        {
            _OnCommand(command);
        }
    }
}
