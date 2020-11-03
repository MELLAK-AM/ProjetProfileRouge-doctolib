import React, { Component } from 'react';
import Home from './Home';

class Search extends Component {
    constructor(props) {
        super(props);
        this.state = {  }
    }
    render() { 
        return ( 
            <div classeName="container">
                <div className="row">
                    <input className="col form-control" onChange={this.changeSearch} placeholder="votre recherche"></input>
                    <button onClick={this.valideClick} className="col-4 btn btn-primary">Valider</button>
                </div>

            </div>
         );
    }
}
 
export default Search ;