/*********************************************************************************
 * Project: < JOKE FRAMEWORK 2020 … >
 * Assignment: < assignment 1 >
 * Author(s): < Sureya farah   …>
 * Student Number: < 101062225  >
 * Date: Oct 11 2020
 * Description: <Joke Service Implements our interface and generates chuckNorrisQuote from
 * it own dependency class to our service and returns a random joke >
 **********************************************************************************/

package guru.springframework.joke2020.jokeapp.services;

import guru.springframework.norris.chuck.ChuckNorrisQuotes;
import org.springframework.stereotype.Service;

@Service
public class JokeServiceImpl implements JokeServices {
    private final ChuckNorrisQuotes chuckNorrisQuotes;

    public JokeServiceImpl(){
        this.chuckNorrisQuotes = new ChuckNorrisQuotes();

    }


    @Override
    public String getJoke() {
        return chuckNorrisQuotes.getRandomQuote();
    }
}
