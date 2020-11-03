import React, { Component } from 'react';
import Search from './Search';


class Accueil extends Component {
    constructor(props) {
        super(props);
        this.state = {  }
    }
    render() { 
        return ( 
            <div className="container">

            <div className="navbar navbar-expand-lg navbar-light bg-primary">

                <ul className="navbar-nav mr-auto">

                    <li className="nav-item m-2">

                        <button class="btn btn-primary" type="submit">Doctolib</button>

                    </li>

                    <li className="nav-item m-2">

                        <button class="btn btn-light" type="submit">Vous êtes un praticien ?</button>

                    </li>

                    <li className="nav-item m-2"  >

                        <button class="btn btn-primary" type="submit">Se connecter</button>

                    </li>



                </ul>

            </div>

            <div>

                <img src="https://media.licdn.com/dms/image/C4E1BAQE3OKeRJ-JuOw/company-background_10000/0?e=2159024400&v=beta&t=G7PxmUG516nuNeGrKqyOEDzmEy5rw2B_GfAbGyKk0_w" class="img-fluid" alt="Responsive image" />

                <h1>Réservez une consultation physique chez un professionnel de santé</h1>

            </div>

            <div className="row m-5">

                <Search onChange={(e) => { this.search(e.target.value) }} placeholder="Votre recherche" enterButton="Search" size="large" />

            </div>



        </div>
         );
    }
}
 
export default Accueil;