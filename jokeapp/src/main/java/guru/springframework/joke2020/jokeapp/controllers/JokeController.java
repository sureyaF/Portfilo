/*********************************************************************************
 * Project: < JOKE FRAMEWORK 2020 … >
 * Assignment: < assignment 1 >
 * Author(s): < Sureya farah>
 * Student Number: < 101062225 >
 * Date: Oct 11 2020
 * Description: <Our controller class will use our jokeservice as a variable when an spring dependency
 * needs a new joke or data our auto wired idea is that, instead of your object creating an object it needs
 * (say by using new to instantiate it), this needed object - a dependency - is handed to your object(jokeService)
 * our request mapping will then append our string bahavior to the url>
 **********************************************************************************/

package guru.springframework.joke2020.jokeapp.controllers;

import guru.springframework.joke2020.jokeapp.services.JokeServices;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
public class JokeController {
    private JokeServices jokeServices;

    @Autowired
    public JokeController(JokeServices jokeServices) {

        this.jokeServices = jokeServices;
    }

    @RequestMapping({"/",""})
    public String showJoke(Model model){
        model.addAttribute("joke",jokeServices.getJoke());
        return  "chucknorris";

    }
}
