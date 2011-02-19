﻿using System;
using System.Collections.Generic;

using UML=TSF.UmlToolingFramework.UML;

namespace TSF.UmlToolingFramework.Wrappers.EA {
  public abstract class Parameter : Element, UML.Classes.Kernel.Parameter {
    public Parameter(Model model) : base(model) {}
    
    public abstract UML.Classes.Kernel.ParameterDirectionKind direction 
      { get; set; }
    public abstract UML.Classes.Kernel.ValueSpecification defaultValue 
      { get; set; }
    public abstract UML.Classes.Kernel.ValueSpecification upperValue 
      { get; set; }
    public abstract UML.Classes.Kernel.ValueSpecification lowerValue 
      { get; set; }
    public abstract UML.Classes.Kernel.Operation operation { get; set; }
    public abstract UML.Classes.Kernel.UnlimitedNatural upper { get; set; }
    public abstract UML.Classes.Kernel.Type type { get; set; }
    public abstract UML.Classes.Kernel.VisibilityKind visibility { get; set; }
    public abstract UML.Classes.Kernel.Namespace owningNamespace {get; set; }            
    public abstract String _default { get; set; }
    public abstract bool isOrdered { get; set; }
    public abstract bool isUnique { get; set; }
    public abstract int lower { get; set; }
    public abstract String name { get; set; }
    public abstract String qualifiedName { get; set; }

    public List<UML.Classes.Dependencies.Dependency> clientDependencies {
      get { throw new NotImplementedException(); }
      set { throw new NotImplementedException(); }
    }

    public List<UML.Classes.Dependencies.Dependency> supplierDependencies {
      get { throw new NotImplementedException(); }
      set { throw new NotImplementedException(); }
    }
    
    public override HashSet<UML.Classes.Kernel.Element> ownedElements {
      get { throw new NotImplementedException(); }
      set { throw new NotImplementedException(); }
    }
    
    public override HashSet<UML.Classes.Kernel.Comment> ownedComments {
      get { throw new NotImplementedException(); }
      set { throw new NotImplementedException(); }
    }
    
    public override UML.Classes.Kernel.Element owner {
      get { throw new NotImplementedException(); }
      set { throw new NotImplementedException(); }
    }
    
    public override HashSet<UML.Profiles.Stereotype> stereotypes {
      get { throw new NotImplementedException(); }
      set { throw new NotImplementedException(); }
    }
  }
}
