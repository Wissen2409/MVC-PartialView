using Microsoft.AspNetCore.Mvc;

public class WissenController:Controller{

    public IActionResult Index(){

        IndexViewModel model = new IndexViewModel(){ ImageUrl="https://picsum.photos/200/300"};
        return View(model);
    }
}