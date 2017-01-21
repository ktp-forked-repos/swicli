// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision$</version>
// </file>

// This file is automatically generated - any changes will be lost

#pragma warning disable 1591

namespace Debugger.Wrappers.CorSym
{
	using System;
	
	
	public partial class CorSymBinder_deprecated
	{
		
		private Debugger.Interop.CorSym.CorSymBinder_deprecated wrappedObject;
		
		internal Debugger.Interop.CorSym.CorSymBinder_deprecated WrappedObject
		{
			get
			{
				return this.wrappedObject;
			}
		}
		
		public CorSymBinder_deprecated(Debugger.Interop.CorSym.CorSymBinder_deprecated wrappedObject)
		{
			this.wrappedObject = wrappedObject;
			ResourceManager.TrackCOMObject(wrappedObject, typeof(CorSymBinder_deprecated));
		}
		
		public static CorSymBinder_deprecated Wrap(Debugger.Interop.CorSym.CorSymBinder_deprecated objectToWrap)
		{
			if ((objectToWrap != null))
			{
				return new CorSymBinder_deprecated(objectToWrap);
			} else
			{
				return null;
			}
		}
		
		~CorSymBinder_deprecated()
		{
			object o = wrappedObject;
			wrappedObject = null;
			ResourceManager.ReleaseCOMObject(o, typeof(CorSymBinder_deprecated));
		}
		
		public bool Is<T>() where T: class
		{
			System.Reflection.ConstructorInfo ctor = typeof(T).GetConstructors()[0];
			System.Type paramType = ctor.GetParameters()[0].ParameterType;
			return paramType.IsInstanceOfType(this.WrappedObject);
		}
		
		public T As<T>() where T: class
		{
			try {
				return CastTo<T>();
			} catch {
				return null;
			}
		}
		
		public T CastTo<T>() where T: class
		{
			return (T)Activator.CreateInstance(typeof(T), this.WrappedObject);
		}
		
		public static bool operator ==(CorSymBinder_deprecated o1, CorSymBinder_deprecated o2)
		{
			return ((object)o1 == null && (object)o2 == null) ||
			       ((object)o1 != null && (object)o2 != null && o1.WrappedObject == o2.WrappedObject);
		}
		
		public static bool operator !=(CorSymBinder_deprecated o1, CorSymBinder_deprecated o2)
		{
			return !(o1 == o2);
		}
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		
		public override bool Equals(object o)
		{
			CorSymBinder_deprecated casted = o as CorSymBinder_deprecated;
			return (casted != null) && (casted.WrappedObject == wrappedObject);
		}
		
	}
}

#pragma warning restore 1591
