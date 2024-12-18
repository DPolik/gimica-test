For this project I used Unity 2022 and added a free package from the Asset Store ("2D Casual UI") with the UI assets.
I've setup the "Problem2" scene with the UI canvas that scales with screen size. This canvas has 3 instances of the 
"CurrencyCounter" prefab, which setups the counters with the required elements.

I personally like the WYSIWYG approach to Unity UI, where you work as much as possible in the editor instead of letting 
the runtime code setup things for you, so that is why the visual settings of the currency converters are done in the scene.
The icons and colors are all set in the scene, and each converter is an instance of a prefab that has the generic setup
already done.

The code is divided into 3 parts: view, model and presenter.
- view is a passive monobehaviour that manages all the visual part of the element, has the references to every visual
component needed and receives commands to update/change those components. It doesn't know anything about the other classes.
- model is a data class, contains the currency amount and type data. It doesn't know anything about other classes.
- presenter has a reference to both view and model. It acts as the manager for the other two, sending updates to the 
view and changing the data of the model. In this example the presenter also initializes and contains the model to simplify.
With this separation and encapsulation of concerns, we get a better looking code and it is better prepared for changes 
in each of it's components.

Even though this particular example probably didn't need an MVP architecture, I wanted to show what I'm used to do in 
bigger projects. If I was working on a proof of concept for example, I would probably merge the code into just 1 class 
responsible for everything to speed up development and prove the concept. Afterwards it would be scrapped and probably 
rebuilt if approved.

