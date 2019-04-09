namespace Weights.App
{
    public class SelectListItem<T>{
        
        public string Text {get;set;}
        public T Value {get;set;}

        public SelectListItem(string text, T value){
            Text = text;
            Value = value;
        }
    }
}