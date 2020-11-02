import React, { Component } from 'react';



class Recherche extends Component {
    constructor(props) {
        super(props);
        this.state = {  }
    }
    render() { 
        return ( 
            <div className="container">
                <div className="row">
                    <input className="col form-control" type="search" placeholder="Votre recherche" />

                </div>

            </div>
         );
    }
}
 
export default Recherche;