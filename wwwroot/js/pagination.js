'use strict';

const e = React.createElement;

class Pagination extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            test: false
        };
    }

    render() {
        return e("button", {}, 'Test');
    }
}

const domContainer = document.querySelector('#pagination');
ReactDOM.render(e(Pagination), domContainer);