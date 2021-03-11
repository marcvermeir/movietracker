import React from 'react';
import { Container } from 'rsuite';
import NavMenu from './NavMenu';
import Footer from './Footer';

export default class Layout extends React.Component {

    render() {

        return (
            <>
                <NavMenu />
                <Container fluid>
                    {this.props.children}
                </Container>
                <Footer />
            </>
          );
    }
}