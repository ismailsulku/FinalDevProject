﻿using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        { 
            //defensive coding
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu bir doğrulama sınıfı değildir!");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType); //reflection çalışma anında bir şeyleri çalıştırabilmemiz sağlıyor..
            var entityType = _validatorType.BaseType.GetGenericArguments()[0]; //ProductValidator git basetype ını bul, onun generic argümanlarından ilkini bul
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType); // onun parametrelerini bul.. methodun argümanlarını gez (add in productı) eğer o entity tipinde ise
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity); // validate et (doğrulama)
            }
        }
    }
}
