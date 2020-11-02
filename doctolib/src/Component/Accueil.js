import React, { Component } from 'react';
import Recherche from './Recherche';



class Accueil extends Component {
    constructor(props) {
        super(props);
        this.state = {}
    }



    render() {
        return (
            <div className="navbar navbar-expand-lg navbar-light bg-primary">
                <ul className="navbar-nav mr-auto">
                    <li className="nav-item m-2">
                        <button class="btn btn-primary" type="submit">Doctolib</button>
                    </li>
                    <li className="nav-item m-2">
                        <button class="btn btn-primary" type="submit">Vous êtes un professionnel?</button>
                    </li>
                    <li className="nav-item m-2">
                        <button class="btn btn-primary" type="submit">Se connecter(gérer mes RDV)</button>
                    </li>

                </ul>
              <recherche recherche={this.recherche}></recherche>
            </div>
        );
    }
}

export default Accueil;