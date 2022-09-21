using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Test_List.Helpers
{
    public class TypeBinder<T> : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var propetyName = bindingContext.ModelName;
            var valueProviderResult = bindingContext.ValueProvider.GetValue(propetyName);

            if (valueProviderResult == ValueProviderResult.None)
            {
                return Task.CompletedTask;
            }
            try
            {
                var deserializedValue = JsonConvert.DeserializeObject<T>(valueProviderResult.FirstValue);
                bindingContext.Result = ModelBindingResult.Success(deserializedValue);
            }
            catch
            {
                bindingContext.ModelState.TryAddModelError(propetyName, "Value is invalid for type List<int>");
            }
            return Task.CompletedTask;
        }
    }
}