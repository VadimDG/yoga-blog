import React from 'react';
import './button.scss';

export function ContentMenuButton(props) {
    return (
        <div className="content-menu-button">
            {props.name}
        </div>
    );
}