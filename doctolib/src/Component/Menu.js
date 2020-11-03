import React, { Component } from 'react';
import { Link } from 'react-router-dom';


class Menu extends Component {
    constructor(props) {
        super(props);
        this.state = {}
    }

    render() {
        return (
            <div className="container">
                <div className="navbar navbar-expand-lg navbar-light bg-primary">
                    <ul className="navbar-nav mr-auto">
                        <li className="nav-item m-2">
                            <Link to='/'>Doctolib</Link>
                        </li>
                        <li className="nav-item m-2">
                            <Link to='/addPraticiens'>Vous êtes un praticien ?</Link>
                        </li>
                        <li className="nav-item m-2"  >
                            <Link to='/Login'>Se connecter</Link>
                        </li>
                    </ul>
                </div>
                <div>
                    <img src="https://media.licdn.com/dms/image/C4E1BAQE3OKeRJ-JuOw/company-background_10000/0?e=2159024400&v=beta&t=G7PxmUG516nuNeGrKqyOEDzmEy5rw2B_GfAbGyKk0_w" class="img-fluid" alt="Responsive image" />
                    <h1>Réservez une consultation physique chez un professionnel de santé</h1>

                </div>

            </div>
        );
    }
}

export default Menu;